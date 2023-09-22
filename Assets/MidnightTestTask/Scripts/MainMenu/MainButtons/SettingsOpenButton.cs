using MidnightTestTask.Scripts.MainMenu.Popups.SettingsPopup;
using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.MainButtons
{
    public class SettingsOpenButton : MonoBehaviour
    {
        [SerializeField] private PopupSettings _popupSettings;
        
        public void OpenCustomizationPopup()
        {
            _popupSettings.PopupAppearAnimation();
        }
    }
}