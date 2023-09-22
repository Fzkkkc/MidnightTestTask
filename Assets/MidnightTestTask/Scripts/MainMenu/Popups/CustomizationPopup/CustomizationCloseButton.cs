using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.CustomizationPopup
{
    public class CustomizationCloseButton : MonoBehaviour
    {
        [SerializeField] private PopupCustomization _popupCustomization;
        
        public void CloseCustomizationPopup()
        {
            _popupCustomization.PopupDisappearAnimation();
        }
    }
}