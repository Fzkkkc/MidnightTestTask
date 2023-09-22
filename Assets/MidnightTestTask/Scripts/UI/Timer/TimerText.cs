using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.UI.Timer
{
    public class TimerText : MonoBehaviour
    {
        [SerializeField] private Text _timerText;
    
        public MainTimer mainTimer;

        public void UpdateTimerText()
        {
            _timerText.text = $"{mainTimer.SecondsLeft.ToString()}s";
        }
    }
}