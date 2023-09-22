using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace MidnightTestTask.Scripts.UI.Timer
{
    public class MainTimer : MonoBehaviour
    {
        public int SecondsLeft { get; private set; }
        
        public TimerText TimerText;
        
        public static UnityEvent OnTimerEnded = new UnityEvent();

        [SerializeField] private int _timerDuration = 120;
        
        private void Start()
        {
            SetTimerDuration(_timerDuration);
            StartCoroutine(GameTimer());
        }
    
        private IEnumerator GameTimer()
        {
            while (SecondsLeft > 0)
            {
                yield return new WaitForSecondsRealtime(1f);

                SecondsLeft--; 
                TimerText.UpdateTimerText();
            }
            
            OnTimerEnded.Invoke();
        }

        private void SetTimerDuration(int value)
        {
            SecondsLeft = value;
        }
    }
}