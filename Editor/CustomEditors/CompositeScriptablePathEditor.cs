using UnityEditor;
using UnityEngine;

namespace UniTools.IO
{
    [CustomEditor(typeof(CompositeScriptablePath))]
    public sealed class CompositeScriptablePathEditor : Editor
    {
        // private SerializedProperty m_value = default;
        private SerializedProperty m_parent = default;

        private SerializedProperty m_value = default;
        // private CompositeScriptablePath m_target = default;

        // protected override
        private void OnEnable()
        {
            // base.OnEnable();
            m_parent = serializedObject.FindProperty(nameof(m_parent));
            m_value = serializedObject.FindProperty(nameof(m_value));
            // m_target = (CompositeScriptablePath) target;
            // m_outputPath = serializedObject.FindProperty(nameof(m_outputPath));
            // m_scheme = serializedObject.FindProperty(nameof(m_scheme));
            // m_useModernBuildSystem = serializedObject.FindProperty(nameof(m_useModernBuildSystem));
        }

        public override void OnInspectorGUI()
        {
            // EditorGUILayout.HelpBox("Use Development Provisioning Profile for the Archive step.", MessageType.Info);

            // base.OnInspectorGUI();

            Color c = GUI.color;

            if (m_parent.objectReferenceValue != null)
            {
                EditorGUILayout.LabelField(target.ToString());
            }

            if (m_parent.objectReferenceValue == null)
            {
                GUI.color = Color.red;
            }

            EditorGUILayout.PropertyField(m_parent);
            GUI.color = c;
            EditorGUILayout.PropertyField(m_value);
            // EditorGUILayout.PropertyField(m_scheme);
            // EditorGUILayout.PropertyField(m_useModernBuildSystem);

            serializedObject.ApplyModifiedProperties();
        }
    }
}