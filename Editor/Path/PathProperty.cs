using System;
using UnityEngine;

namespace UniTools.IO
{
    [Serializable]
    public sealed class PathProperty
    {
        [SerializeField] private PathTypes m_type = PathTypes.String;
        [SerializeField] private string m_path = default;
        [SerializeField] private BaseScriptablePath m_scriptablePath = default;

        private PathProperty()
        {
        }

        public PathProperty(string path)
        {
            m_path = path;
        }

        public override string ToString()
        {
            if (m_type == PathTypes.Scriptable)
            {
                if (m_scriptablePath == null)
                {
                    throw new Exception("Invalid path value!");
                }

                return m_scriptablePath.ToString();
            }

            if (string.IsNullOrEmpty(m_path))
            {
                throw new Exception("Invalid path value!");
            }

            return m_path;
        }
    }
}