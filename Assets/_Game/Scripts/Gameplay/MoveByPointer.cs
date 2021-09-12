using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class MoveByPointer : MonoBehaviour
    {
        public float offsetZ = 0f;
        public float moveSpeed = 10f;

        protected Camera m_CameraMain;
        protected int m_CurPointerId = -1;
        protected bool m_CanUsePointer = false;

        private void Awake()
        {
            OnAwake();
        }

        protected virtual void OnAwake()
        {

        }

        private void Start()
        {
            m_CameraMain = Camera.main;
            OnStart();
        }

        protected virtual void OnStart()
        {

        }

        private void Update()
        {
            {
#if UNITY_EDITOR || UNITY_STANDALONE
                UpdateMouseInput();
#else
                UpdateTouchInput();
#endif
            }
        }

        public void UpdateMouseInput()
        {
            if (m_CameraMain == null) return;
            if (Input.GetMouseButtonDown(0))
            {
                OnPointerDown(m_CameraMain.ScreenToWorldPoint(Input.mousePosition));
            }
            else if (Input.GetMouseButton(0))
            {
                OnPointerMove(m_CameraMain.ScreenToWorldPoint(Input.mousePosition));
            }
            else if (Input.GetMouseButtonUp(0))
            {
                OnPointerUp(m_CameraMain.ScreenToWorldPoint(Input.mousePosition));
            }
        }

        public void UpdateTouchInput()
        {
            if (m_CameraMain == null) return;

            if (Input.touchCount > 0)
            {
                for (int i = 0; i < Input.touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);
                    if (m_CurPointerId == -1)
                    {
                        if (touch.phase == TouchPhase.Began)
                        {
                            m_CurPointerId = touch.fingerId;
                            OnPointerDown(m_CameraMain.ScreenToWorldPoint(touch.position));
                        }
                    }
                    else
                    {
                        if (m_CurPointerId == touch.fingerId)
                        {
                            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
                            {
                                OnPointerMove(m_CameraMain.ScreenToWorldPoint(touch.position));
                            }
                            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                            {
                                m_CurPointerId = -1;
                                OnPointerUp(m_CameraMain.ScreenToWorldPoint(touch.position));
                            }
                        }
                    }
                }
            }
            else
            {
                m_CurPointerId = -1;
            }
        }

        protected virtual void OnPointerDown(Vector3 position)
        {

        }

        protected virtual void OnPointerMove(Vector3 position)
        {
            var transformPosition = transform.position;
            transformPosition.z = offsetZ;
            position.z = offsetZ;
            transform.position = Vector3.MoveTowards(transformPosition, position, moveSpeed * Time.deltaTime);
        }

        protected virtual void OnPointerUp(Vector3 position)
        {

        }
    }
}
