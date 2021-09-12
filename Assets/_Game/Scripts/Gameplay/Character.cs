using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class Character : MonoBehaviour
    {
        public int level;
        public int experience;

        protected Health m_Health;
        protected Camera m_MainCamera;

        private void Awake()
        {
            m_Health = GetComponent<Health>();
        }

        void Start()
        {
            m_MainCamera = Camera.main;
        }

        private void Update()
        {

        }
    }
}