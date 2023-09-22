using MidnightTestTask.Scripts.UI.DriftScore;
using TMPro;
using UnityEngine;

namespace MidnightTestTask.Scripts.UI.EndPanel
{
    public class EndPanelCoinsWonCountText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinsWonCountText;

        [SerializeField] private PlayerDriftScore _playerDriftScore; 
        
        public void UpdateCoinsWonCount()
        {
            _coinsWonCountText.text = $"You won {_playerDriftScore.GetPlayerDriftScore().ToString()}$";
        }
    }
}