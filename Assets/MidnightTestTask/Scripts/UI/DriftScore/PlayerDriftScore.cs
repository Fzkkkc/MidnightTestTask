using System.Collections;
using MidnightTestTask.Scripts.Car;
using UnityEngine;

namespace MidnightTestTask.Scripts.UI.DriftScore
{
    public class PlayerDriftScore : MonoBehaviour
    {
        [SerializeField] private string _carObjectName;
        
        private int CurrentDriftScore { get; set; }
        
        public UIDriftScoreText UIDriftScoreText;

        private CarController carController;
        
        private IEnumerator Start()
        {
            while (carController == null)
            {
                GameObject carObject = GameObject.Find(_carObjectName);
                if (carObject != null)
                {
                    carController = carObject.GetComponent<CarController>();
                }
                yield return null; 
            }
        }
        
        private void IncreaseScore()
        {
            CurrentDriftScore++;
            UIDriftScoreText.UpdateScoreText();
        }
        
        public int GetPlayerDriftScore()
        {
            return CurrentDriftScore;
        }
        
        public void ResetCurrentDriftScore()
        {
            CurrentDriftScore = 0;
        }
        
        private void Update()
        {
            if(Input.GetKey(KeyCode.Space) && carController != null && carController.isDrifting)
                IncreaseScore();
        }
    }
}