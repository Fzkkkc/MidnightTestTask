using System.Collections;
using MidnightTestTask.Scripts.SceneManagement;
using MidnightTestTask.Scripts.UI.Transition;
using UnityEngine;

namespace MidnightTestTask.Scripts.MainMenu.Popups.SelectModePopup
{
    public class OnlineButtonPopupSelectMode : MonoBehaviour
    {
        [SerializeField] private TransitionAnimation _transitionAnimation;

        private SceneLoader _sceneLoader = new SceneLoader();
        
        private IEnumerator GameplaySceneCoroutine()
        {
            _transitionAnimation.ShowTransitionAnimation();
            
            yield return new WaitForSeconds(1.4f);
            
            _sceneLoader.LoadLoadingScene();
        }
        
        public void LoadLoadingScene()
        {
            StartCoroutine(GameplaySceneCoroutine());
        }
    }
}