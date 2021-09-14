using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    [CreateAssetMenu(menuName = "Kubird/Configs/Manager Dict")]
    public class ManagerDict : ScriptableObject
    {
        public List<GameObject> managerDict;
    }
}