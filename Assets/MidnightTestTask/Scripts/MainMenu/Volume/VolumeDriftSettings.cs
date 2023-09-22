using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.MainMenu.Volume
{
    public class VolumeDriftSettings : MonoBehaviour
    {
        [SerializeField] private Slider _volumeDriftSlider;
        private const string _volumeDriftKey = "VolumeDrift";

        private void Start()
        {
            if (PlayerPrefs.HasKey(_volumeDriftKey))
            {
                float savedVolume = PlayerPrefs.GetFloat(_volumeDriftKey);
                _volumeDriftSlider.value = savedVolume;
            }
        }
        
        public void UpdateVolume()
        {
            PlayerPrefs.SetFloat(_volumeDriftKey, _volumeDriftSlider.value);
            PlayerPrefs.Save();
        }
    }
}