using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kubird
{
    public enum ColorFamily { Blue, Orange, Green, Purple, Yellow, Pink }

    [CreateAssetMenu(menuName = "Kubird/Data/Skin Data Dict")]
    public class SkinDataDict : ScriptableObject
    {
        public List<ColorFamily> dataDict;

        public static string TranslateSkinId(ColorFamily colorFamily) => colorFamily switch
        {
            ColorFamily.Blue => "Water",
            ColorFamily.Orange => "Fire",
            ColorFamily.Green => "AIR",
            ColorFamily.Purple => "Dark",
            ColorFamily.Yellow => "Light",
            ColorFamily.Pink => "AIR",
            _ => "AIR",
        };
    }

    [Serializable]
    public class SkinData
    {
        public ColorFamily colorFamily;
    }

    [Serializable]
    public class SkinProfileData
    {
        public ColorFamily colorFamily;
        public int id;
        public string skinId;
        public string hornId;
        public string rostrumId;
        public string tailId;
        public string patternId;
        public string feetId;
        public string eyesId;
    }
}