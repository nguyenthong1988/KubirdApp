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

        public int score { get; protected set; } = 0;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            KubirdEvent.OnObstacleDamaged += OnObstacleDamaged;
        }

        private void OnDestroy()
        {
            KubirdEvent.OnObstacleDamaged -= OnObstacleDamaged;
        }

        public void OnObstacleDamaged(Obstacle obstacle)
        {
            score++;
            OnScoreChange?.Invoke(score);
        }
    }
}