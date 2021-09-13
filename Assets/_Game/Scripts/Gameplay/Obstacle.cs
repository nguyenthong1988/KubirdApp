using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class Obstacle : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collider)
        {
            HitCheck(collider);
        }

        protected virtual void HitCheck(Collider2D collider)
        {

        }
    }
}