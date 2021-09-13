using DarkTonic.PoolBoss;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class AxisAutoMove : MonoBehaviour
    {
        public enum Axis { HorizontalLeft, HorizontalRight, VerticalUp, VerticalDown }

        public float moveSpeed;
        public Axis axis;

        protected Vector3 m_Movement;
        protected Vector3 m_WorldScreenSize;
        protected Vector3 m_DirectionMove;

        private void Start()
        {
            m_WorldScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            m_DirectionMove = TranslateAxis();
        }

        private void Update()
        {
            Movement();
            if (transform.position.x < -m_WorldScreenSize.x)
            {
                PoolBoss.Despawn(transform);
            }
        }

        protected void Movement()
        {
            m_Movement = m_DirectionMove * (moveSpeed) * Time.deltaTime;
            transform.Translate(m_Movement, Space.World);
        }

        protected Vector3 TranslateAxis() => axis switch
        {
            Axis.HorizontalLeft => Vector3.left,
            Axis.HorizontalRight => Vector3.right,
            Axis.VerticalUp => Vector3.up,
            Axis.VerticalDown => Vector3.down,
            _ => Vector3.zero,
        };
    }
}