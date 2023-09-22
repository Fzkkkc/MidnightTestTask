using MidnightTestTask.Scripts.MainMenu.Popups.SelectModePopup;
using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.MainButtons
{
    public class PlayButton : MonoBehaviour
    {
        [SerializeField] private PopupSelectMode _popupSelectMode;
        
        /*[SerializeField] private TransitionAnimation _transitionAnimation;

        private NextScene _nextScene = new NextScene();
        
        private IEnumerator GameplaySceneCoroutine()
        {
            _transitionAnimation.ShowTransitionAnimation();
            
            yield return new WaitForSeconds(1.4f);
            
            _nextScene.LoadNextScene();
        }
        
        public void LoadGameplayScene()
        {
            StartCoroutine(GameplaySceneCoroutine());
        }*/

        public void OpenPopupSelectMode()
        {
            _popupSelectMode.PopupAppearAnimation();
        }
    }
}
