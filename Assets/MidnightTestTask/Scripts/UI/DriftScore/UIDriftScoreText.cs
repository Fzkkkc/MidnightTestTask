using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.UI.DriftScore
{
    public class UIDriftScoreText : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;

        public PlayerDriftScore playerDriftScore;
        
        public void UpdateScoreText()
        {
            _scoreText.text = $"{playerDriftScore.GetPlayerDriftScore().ToString()}";
        }
    }
}