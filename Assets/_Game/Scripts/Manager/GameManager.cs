using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public bool initialized { get; protected set; } = false;

        private void Awake()
        {
            initialized = false;

            if (Instance = null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this.gameObject);
                return;
            }
        }
    }

}