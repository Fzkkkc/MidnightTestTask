using System.Collections;
using MidnightTestTask.Scripts.Car;
using MidnightTestTask.Scripts.UI.Timer;
using UnityEngine;

namespace MidnightTestTask.Scripts.UI.EndPanel
{
    public class EndPanelAppearAnimation : MonoBehaviour
    {
        [SerializeField] private string _carObjectName;
        [SerializeField] private Animator _endPanelAnimator;

        [SerializeField] private EndPanelCoinsWonCountText _endPanelCoinsWonCount;
        
         private CarController _carController;

         private IEnumerator Start()
         {
             while (_carController == null)
             {
                 GameObject carObject = GameObject.Find(_carObjectName);
                 if (carObject != null)
                 {
                     _carController = carObject.GetComponent<CarController>();
                 }
                 yield return null; 
             }
         }

        private void OnEnable()
        {
            MainTimer.OnTimerEnded.AddListener(OpenEndPanel);
        }
        
        private void OnDisable()
        {
            MainTimer.OnTimerEnded.AddListener(OpenEndPanel);
        }

        private void OpenEndPanel()
        {
            _carController.CanMove = false;
            _endPanelCoinsWonCount.UpdateCoinsWonCount();
            _endPanelAnimator.SetTrigger("OpenEndPanel");
        }
    }
}