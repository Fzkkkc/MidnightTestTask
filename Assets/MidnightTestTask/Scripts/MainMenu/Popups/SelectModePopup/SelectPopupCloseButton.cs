using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.SelectModePopup
{
    public class SelectPopupCloseButton : MonoBehaviour
    {
        [SerializeField] private PopupSelectMode _popupSelectMode;

        public void ClosePopupSelectMode()
        {
            _popupSelectMode.PopupDisappearAnimation();
        }
    }
}
