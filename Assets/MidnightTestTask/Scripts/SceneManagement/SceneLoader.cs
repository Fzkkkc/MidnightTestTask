using UnityEngine.SceneManagement;

namespace MidnightTestTask.Scripts.SceneManagement
{
    public class SceneLoader
    {
        public void LoadNextScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;

            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }

        public void LoadLoadingScene()
        {
            SceneManager.LoadScene("LoadingScene");
        }

        public void LoadGameplayScene()
        {
            SceneManager.LoadScene("GamePlaySceneOffline");
        }
        
        public void LoadMenuScene()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
