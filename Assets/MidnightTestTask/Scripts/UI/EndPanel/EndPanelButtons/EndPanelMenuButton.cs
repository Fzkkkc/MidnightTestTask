using System.Collections;
using MidnightTestTask.Scripts.SceneManagement;
using MidnightTestTask.Scripts.UI.Transition;
using UnityEngine;

namespace MidnightTestTask.Scripts.UI.EndPanel.EndPanelButtons
{
    public class EndPanelMenuButton : MonoBehaviour
    {
        [SerializeField] private TransitionAnimation _transitionAnimation;

        private SceneLoader _sceneLoader = new SceneLoader();
        
        private IEnumerator MenuSceneCoroutine()
        {
            _transitionAnimation.ShowTransitionAnimation();
            
            yield return new WaitForSeconds(1.4f);
            
            _sceneLoader.LoadMenuScene();
        }
        
        public void LoadMenuScene()
        {
            StartCoroutine(MenuSceneCoroutine());
        }
    }
}