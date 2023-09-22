using MidnightTestTask.Scripts.MainMenu.Popups.CustomizationPopup;
using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.MainButtons
{
    public class CustomizationOpenButton : MonoBehaviour
    {
        [SerializeField] private PopupCustomization _popupCustomization;
        
        public void OpenCustomizationPopup()
        {
            _popupCustomization.PopupAppearAnimation();
        }
    }
}
