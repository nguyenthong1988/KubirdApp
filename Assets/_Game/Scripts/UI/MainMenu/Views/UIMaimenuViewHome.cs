using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class UIMaimenuViewHome : MonoBehaviour
    {
        [SerializeField] ModelController m_ModelController;

        private int m_SkinIndex = 0;

        public void OnButtonEndless()
        {
            AppManager.Instance.LoadScene(SceneType.KubirdEndless);
        }

        public void OnButtonNextSkin()
        {
            m_SkinIndex++;
            m_SkinIndex = Mathf.Clamp(m_SkinIndex, 0, 5);
            m_ModelController.SetSkin((ColorFamily)m_SkinIndex);
            SaveSkinIndex();
        }

        public void OnButtonPrevSkin()
        {
            m_SkinIndex--;
            m_SkinIndex = Mathf.Clamp(m_SkinIndex, 0, 5);
            m_ModelController.SetSkin((ColorFamily)m_SkinIndex);
            SaveSkinIndex();
        }

        private void SaveSkinIndex()
        {
            PlayerPrefs.SetInt("_save_skin_index", m_SkinIndex);
            PlayerPrefs.Save();
        }
    }
}