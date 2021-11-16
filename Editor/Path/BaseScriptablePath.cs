using UnityEngine;

namespace UniTools.IO
{
    public abstract class BaseScriptablePath : ScriptableObject
    {
        [SerializeField] private string m_value = default;

        public string Value
        {
            get => m_value;
            set => m_value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}