using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Kubird
{
    public class UIGameHub : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI m_GameScoreText;

        private void OnEnable()
        {
            KubirdManager.OnScoreChange += OnScoreChange;
        }

        private void OnDisable()
        {
            KubirdManager.OnScoreChange -= OnScoreChange;
        }

        private void OnScoreChange(int score)
        {
            m_GameScoreText.text = $"Score: {score}";
        }
    }
}