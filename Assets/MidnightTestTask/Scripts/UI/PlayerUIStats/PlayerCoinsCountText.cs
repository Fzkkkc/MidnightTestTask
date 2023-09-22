using MidnightTestTask.Scripts.Player.PlayerBank;
using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.UI.PlayerUIStats
{
    public class PlayerCoinsCountText : MonoBehaviour
    {
        [SerializeField] private Text _playerCoinsCountText;
        
        [SerializeField] private PlayerCoinsCount _playerCoinsCount;
        
        public void UpdatePlayerCoinsCount()
        {
            _playerCoinsCountText.text = $"{_playerCoinsCount.GetPlayerCoinsAmount().ToString()}";
        }
    }
}