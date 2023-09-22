using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.SettingsPopup
{
    public class SettingsCloseButton : MonoBehaviour
    {
        [SerializeField] private PopupSettings _popupSettings;
        
        public void CloseCustomizationPopup()
        {
            _popupSettings.PopupDisappearAnimation();
        }
    }
}