using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkTonic.PoolBoss;

namespace Kubird
{
    public class ObstacleGenerator : MonoBehaviour
    {
        public static ObstacleGenerator Instance = null;

        private Vector3 m_WorldScreenSize;

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            m_WorldScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            m_WorldScreenSize.z = 0;

            transform.position = m_WorldScreenSize;

            InvokeRepeating("SpawnMob", 2.0f, 1f);
        }

        void SpawnMob()
        {
            var position = transform.position;
            position.y = Random.Range(-m_WorldScreenSize.y, m_WorldScreenSize.y);

            PoolBoss.SpawnInPool("Mob", position, Quaternion.identity);
        }
    }
}