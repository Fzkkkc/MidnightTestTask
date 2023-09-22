using MidnightTestTask.Scripts.MainMenu.PlayerCoins;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.MainMenu.Popups.CustomizationPopup
{
    public class CarColorCustomization : MonoBehaviour
    {
        [SerializeField] private Button _buttonRedColor;
        [SerializeField] private Button _buttonBlueColor;
        [SerializeField] private Button _buttonGreenColor;

        [SerializeField] private TextMeshProUGUI _redButtonText;
        [SerializeField] private TextMeshProUGUI _blueButtonText;
        [SerializeField] private TextMeshProUGUI _greenButtonText;

        [SerializeField] private PlayerBankMenu _playerCoinsCount;
        
        private const string PlayerPrefsColorKey = "CarColor";
        
        private const string BlueColorKey = "BoughtBlueColor";
        private const string GreenColorKey = "BoughtGreenColor";

        private bool _isPlayerBoughtBlueColor = false;
        private bool _isPlayerBoughtGreenColor = false;
        
        private void Start()
        {
            GetPlayerBoughtColors();
            GetCarColor();
        }
        
        private void GetPlayerBoughtColors()
        {
            _isPlayerBoughtBlueColor = PlayerPrefs.GetInt(BlueColorKey, 0) == 1;
            _isPlayerBoughtGreenColor = PlayerPrefs.GetInt(GreenColorKey, 0) == 1;

            if (_isPlayerBoughtBlueColor)
                _blueButtonText.text = "Equip";
            
            if (_isPlayerBoughtGreenColor)
                _greenButtonText.text = "Equip";
        }

        public void SetCarColorRed()
        {
            PlayerPrefs.SetInt(PlayerPrefsColorKey, 1);
            RedButtonClickedButtonsSettings();
            RedButtonClickedTextSettings();
        }
        
        public void SetCarColorBlue()
        {
            if (PlayerPrefs.GetInt(BlueColorKey) == 0)
            {
                _isPlayerBoughtBlueColor = _playerCoinsCount.Buy(300);
                
                if (!_isPlayerBoughtBlueColor)
                {
                    return;
                }
            }
            
            PlayerPrefs.SetInt(PlayerPrefsColorKey, 2);
            PlayerPrefs.SetInt(BlueColorKey, 1);
            BlueButtonClickedButtonsSettings();
            BlueButtonClickedTextSettings();
        }
        
        public void SetCarColorGreen()
        {
            if (PlayerPrefs.GetInt(GreenColorKey) == 0)
            {
                _isPlayerBoughtGreenColor = _playerCoinsCount.Buy(300);
                
                if (!_isPlayerBoughtGreenColor)
                {
                    return;
                }
            }
            
            PlayerPrefs.SetInt(PlayerPrefsColorKey, 3);
            PlayerPrefs.SetInt(GreenColorKey, 1);
            GreenButtonClickedButtonsSettings();
            GreenButtonClickedTextSettings();
        }

        private void RedButtonClickedButtonsSettings()
        {
            _buttonRedColor.interactable = false;
            _buttonBlueColor.interactable = true;
            _buttonGreenColor.interactable = true;
        }

        private void BlueButtonClickedButtonsSettings()
        {
            _buttonRedColor.interactable = true;
            _buttonBlueColor.interactable = false;
            _buttonGreenColor.interactable = true;
        }

        private void GreenButtonClickedButtonsSettings()
        {
            _buttonRedColor.interactable = true;
            _buttonBlueColor.interactable = true;
            _buttonGreenColor.interactable = false;
        }

        private void RedButtonClickedTextSettings()
        {
            _redButtonText.text = "Equipped";
            
            if(_isPlayerBoughtBlueColor)
                _blueButtonText.text = "Equip";
            
            if(_isPlayerBoughtGreenColor)
                _greenButtonText.text = "Equip";
        }
        
        private void BlueButtonClickedTextSettings()
        {
            _redButtonText.text = "Equip";
            _blueButtonText.text = "Equipped";
            
            if(_isPlayerBoughtGreenColor)
                 _greenButtonText.text = "Equip";
        }
        
        private void GreenButtonClickedTextSettings()
        {
            _redButtonText.text = "Equip";
            
            if(_isPlayerBoughtBlueColor)
                _blueButtonText.text = "Equip";
            
            _greenButtonText.text = "Equipped";
        }
        
        private void GetCarColor()
        {
            int carColor = PlayerPrefs.GetInt(PlayerPrefsColorKey);
            
            if (carColor != 2 && carColor != 3)
            {
                SetCarColorRed();
            }
            else
            {
                switch (carColor)
                {
                    case 2:
                        SetCarColorBlue();
                        break;
                    case 3:
                        SetCarColorGreen();
                        break;
                }
            }
        }
    }
}