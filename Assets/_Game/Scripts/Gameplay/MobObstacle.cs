using DarkTonic.PoolBoss;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class MobObstacle : Obstacle
    {
        [SerializeField]
        private GameObject m_ExplosionPrefab;

        private void Start()
        {
            
        }

        public void Explosion()
        {
            if (m_ExplosionPrefab != null)
            {
                var explosion = Instantiate(m_ExplosionPrefab, transform.position, transform.rotation);
                Destroy(explosion, 1f);
            }
        }

        protected override void HitCheck(Collider2D collider)
        {
            var bullet = collider.GetComponentInParent<UbhPlayerBullet>();
            if (bullet)
            {
                KubirdEvent.OnObstacleDamaged?.Invoke(this);
                Explosion();
                PoolBoss.Despawn(transform);
            }
        }
    }
}