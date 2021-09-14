using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

namespace Kubird
{
    public class ModelController : MonoBehaviour
    {
        [SerializeField] SkeletonAnimation m_Animator;

        public void ChangeSkin(ColorFamily colorFamily)
        {
            string skinId = SkinDataDict.TranslateSkinId(colorFamily);
            m_Animator.skeleton.SetSkin(skinId);
        }
    }
}