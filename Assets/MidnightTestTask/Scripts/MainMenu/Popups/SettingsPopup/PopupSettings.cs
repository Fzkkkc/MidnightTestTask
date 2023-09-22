using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.SettingsPopup
{
    public class PopupSettings : MonoBehaviour
    {
        [SerializeField] private Animator _popupSettingsAnimator;

        public void PopupAppearAnimation()
        {
            _popupSettingsAnimator.SetTrigger("OpenSettings");
        }
        
        public void PopupDisappearAnimation()
        {
            _popupSettingsAnimator.SetTrigger("CloseSettings");
        }
    }
}