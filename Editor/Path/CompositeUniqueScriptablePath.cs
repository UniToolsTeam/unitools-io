using System;
using System.IO;
using UnityEngine;

namespace  UniTools.IO
{
    [CreateAssetMenu(
        fileName = nameof(CompositeUniqueScriptablePath),
        menuName = nameof(UniTools) + "/" + nameof(UniTools.IO) + "/" + nameof(CompositeUniqueScriptablePath)
    )]
    public sealed class CompositeUniqueScriptablePath : BaseScriptablePath
    {
        [SerializeField] private BaseScriptablePath m_parent = default;

        public override string ToString()
        {
            if (m_parent == null)
            {
                throw new Exception("Invalid parent path value!");
            }

            return Path.Combine(m_parent.ToString(), Guid.NewGuid().ToString(), base.ToString());
        }
    }
}