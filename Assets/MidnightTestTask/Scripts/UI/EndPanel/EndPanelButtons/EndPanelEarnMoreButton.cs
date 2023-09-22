using MidnightTestTask.Scripts.Player.PlayerBank;
using MidnightTestTask.Scripts.UI.DriftScore;
using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.UI.EndPanel.EndPanelButtons
{
    public class EndPanelEarnMoreButton : MonoBehaviour
    {
        [SerializeField] private Button _earnMoreButton;

        [SerializeField] private PlayerDriftScore _playerDriftScore;
        [SerializeField] private PlayerCoinsCount _playerCoinsCount;
        
        private void Start()
        {
            _earnMoreButton.interactable = true;
        }

        public void EarnMorePoints()
        {
            _earnMoreButton.interactable = false;
            int prizePointsCount = _playerDriftScore.GetPlayerDriftScore();
            _playerCoinsCount.IncreasePlayerScore(prizePointsCount);
        }
    }
}
