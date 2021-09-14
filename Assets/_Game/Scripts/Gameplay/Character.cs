using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class Character : MonoBehaviour
    {
        public int level;
        public int experience;

        [Header("Reference")]
        [SerializeField] ModelController m_ModelController;

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

        public void Build()
        {
            m_ModelController.SetSkin((ColorFamily)PlayerPrefs.GetInt("_save_skin_index", 0));
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            HitCheck(collider);
        }

        private void HitCheck(Collider2D collider)
        {

        }

        public ModelController modelController => modelController;
    }
}