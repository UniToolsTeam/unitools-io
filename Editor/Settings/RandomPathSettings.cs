using System;
using UnityEngine;

namespace UniTools.IO
{
    [CreateAssetMenu(
        fileName = nameof(RandomPathSettings),
        menuName = nameof(UniTools) + "/IO/" + nameof(RandomPathSettings)
    )]
    public sealed class RandomPathSettings : ScriptableObject
    {
        [SerializeField] private string m_randomPathId = default;

        public string RandomId => m_randomPathId;

        public void GenerateRandomId()
        {
            m_randomPathId = Guid.NewGuid().ToString();
        }
    }
}