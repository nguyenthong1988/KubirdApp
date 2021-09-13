using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class UIMaimenuViewHome : MonoBehaviour
    {
        public void OnButtonEndless()
        {
            AppManager.Instance.LoadScene(SceneType.KubirdEndless);
        }
    }
}