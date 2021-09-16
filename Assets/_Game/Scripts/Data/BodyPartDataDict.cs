using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kubird
{
    public enum BodyPartCategory { Body, Horn, Rostrum, Tail, Wing, Decor, Feet, Eyes }

    [CreateAssetMenu(menuName = "Kubird/Data/Body Part Data Dict")]
    public class BodyPartDataDict : ScriptableObject
    {
        public List<BodyPartData> dataDict;

        public BodyPartData GetPartData(BodyPartCategory category)
        {
            return dataDict.FirstOrDefault(c => c.category == category);
    }
    }

    [Serializable]
    public class BodyPartData 
    {
        public BodyPartCategory category;
        public List<string> list;
    }
}
