using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.MainMenu.PlayerCoins
{
    public class PlayerBankMenu : MonoBehaviour
    {
        [SerializeField] private Text _playerCoinsText;

        public int _playerCoinsCount; 

        private const string PlayerPrefsKey = "PlayerBank";
        
        private void Start()
        {
            LoadPlayerScore();
            ShowPlayerCoinsText();
        }

        private void ShowPlayerCoinsText()
        {
            _playerCoinsText.text = $"{GetPlayerCoinsCount().ToString()}";
        }
        
        private int GetPlayerCoinsCount()
        {
           return _playerCoinsCount = PlayerPrefs.GetInt(PlayerPrefsKey);
        }
        
        private void SavePlayerScore()
        {
            PlayerPrefs.SetInt(PlayerPrefsKey, _playerCoinsCount);
            PlayerPrefs.Save(); 
        }
        
        private void LoadPlayerScore()
        {
            if (PlayerPrefs.HasKey(PlayerPrefsKey))
            {
                _playerCoinsCount = PlayerPrefs.GetInt(PlayerPrefsKey);
            }
        }
        
        private bool CanBuy(int cost)
        {
            return _playerCoinsCount >= cost;
        }
        
        public bool Buy(int cost)
        {
            if (CanBuy(cost))
            {
                _playerCoinsCount -= cost;
                SavePlayerScore();
                ShowPlayerCoinsText();
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
