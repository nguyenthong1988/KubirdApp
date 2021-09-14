using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kubird
{
    public class KubirdManager : MonoBehaviour
    {
        public static Action<int> OnScoreChange;

        public static KubirdManager Instance;

        [SerializeField] Character m_Character;

        public int score { get; protected set; } = 0;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            KubirdEvent.OnObstacleDamaged += OnObstacleDamaged;
            StartCoroutine(CorInitCharacter());
        }

        private void OnDestroy()
        {
            KubirdEvent.OnObstacleDamaged -= OnObstacleDamaged;
        }

        private IEnumerator CorInitCharacter()
        {
            yield return new WaitUntil(() => ProfileManager.Instance && ProfileManager.Instance.initialized);

            m_Character.Build();
        }

        public void OnObstacleDamaged(Obstacle obstacle)
        {
            score++;
            OnScoreChange?.Invoke(score);
        }
    }
}