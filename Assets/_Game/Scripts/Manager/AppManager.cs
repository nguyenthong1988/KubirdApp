using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kubird
{
    public class AppManager : MonoBehaviour
    {
        private static Dictionary<SceneType, string> m_SceneMap = new Dictionary<SceneType, string>()
        {
            { SceneType.MainMenu, "MainMenu"},
            { SceneType.KubirdEndless, "KubirdGame"},
        };

        public static AppManager Instance;

        public bool initialized { get; protected set; } = false;

        private void Awake()
        {
            initialized = false;

            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this.gameObject);
                return;
            }
        }

        public void LoadScene(SceneType sceneType)
        {
            if (m_SceneMap.ContainsKey(sceneType))
            {
                SceneManager.LoadScene(m_SceneMap[sceneType]);
            }
        }
    }

    public enum SceneType
    {
        MainMenu,
        KubirdEndless,
    }
}