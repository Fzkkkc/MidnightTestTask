using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.CustomizationPopup
{
    public class PopupCustomization : MonoBehaviour
    {
        [SerializeField] private Animator _popupCustomizationAnimator;

        public void PopupAppearAnimation()
        {
            _popupCustomizationAnimator.SetTrigger("OpenCustomizationPopup");
        }
        
        public void PopupDisappearAnimation()
        {
            _popupCustomizationAnimator.SetTrigger("CloseCustomizationPopup");
        }
    }
}