using MidnightTestTask.Scripts.UI.DriftScore;
using MidnightTestTask.Scripts.UI.PlayerUIStats;
using MidnightTestTask.Scripts.UI.Timer;
using UnityEngine;

namespace MidnightTestTask.Scripts.Player.PlayerBank
{
    public class PlayerCoinsCount : MonoBehaviour
    {
        private int PlayerCoinsAmount { get; set; }

        private const string PlayerPrefsKey = "PlayerBank";

        [SerializeField] private PlayerCoinsCountText _playerCoinsCountText;
        [SerializeField] private PlayerDriftScore _playerDriftScore;
        
        private void Start()
        {
            LoadPlayerScore(); 
            _playerCoinsCountText.UpdatePlayerCoinsCount();
        }
        
        private void OnEnable()
        {
            MainTimer.OnTimerEnded.AddListener(IncreaseCurrentPlayerScoreDriftCase);
        }
        
        private void OnDisable()
        {
            MainTimer.OnTimerEnded.AddListener(IncreaseCurrentPlayerScoreDriftCase);
        }

        private void IncreaseCurrentPlayerScoreDriftCase()
        {
            PlayerCoinsAmount += _playerDriftScore.GetPlayerDriftScore();
            _playerCoinsCountText.UpdatePlayerCoinsCount();
            SavePlayerScore();
        }

        public void IncreasePlayerScore(int value)
        {
            PlayerCoinsAmount += value;
            _playerCoinsCountText.UpdatePlayerCoinsCount();
            SavePlayerScore();
        }

        public void ResetCurrentPlayerScore()
        {
            PlayerCoinsAmount = 0;
            SavePlayerScore(); 
        }
        
        public int GetPlayerCoinsAmount()
        {
            return PlayerCoinsAmount;
        }

        private void SavePlayerScore()
        {
            PlayerPrefs.SetInt(PlayerPrefsKey, PlayerCoinsAmount);
            PlayerPrefs.Save(); 
        }
        
        private void LoadPlayerScore()
        {
            if (PlayerPrefs.HasKey(PlayerPrefsKey))
            {
                PlayerCoinsAmount = PlayerPrefs.GetInt(PlayerPrefsKey);
            }
        }
        
        private bool CanBuy(int cost)
        {
            return PlayerCoinsAmount >= cost;
        }
        
        public bool Buy(int cost)
        {
            if (CanBuy(cost))
            {
                PlayerCoinsAmount -= cost;
                SavePlayerScore();
                _playerCoinsCountText.UpdatePlayerCoinsCount();
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}