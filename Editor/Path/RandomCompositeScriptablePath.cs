using System;
using System.IO;
using UnityEngine;

namespace UniTools.IO
{
    [CreateAssetMenu(
        fileName = nameof(RandomCompositeScriptablePath),
        menuName = nameof(UniTools) + "/" + nameof(IO) + "/"+ nameof(RandomCompositeScriptablePath)
    )]
    public sealed class RandomCompositeScriptablePath : BaseScriptablePath
    {
        [SerializeField] private BaseScriptablePath m_parent = default;
        [SerializeField] private RandomPathSettings m_randomPathSettings = default;

        public override string ToString()
        {
            if (m_parent == null)
            {
                throw new Exception("Invalid parent path value!");
            }

            return Path.Combine(m_parent.ToString(), m_randomPathSettings.RandomId, base.ToString());
        }
    }

}