using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.SelectModePopup
{
    public class PopupSelectMode : MonoBehaviour
    {
        [SerializeField] private Animator _popupSelectModeAnimator;

        public void PopupAppearAnimation()
        {
            _popupSelectModeAnimator.SetTrigger("ShowPopupSelect");
        }
        
        public void PopupDisappearAnimation()
        {
            _popupSelectModeAnimator.SetTrigger("ClosePopupSelect");
        }
    }
}