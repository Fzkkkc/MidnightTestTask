using UnityEngine;
using UnityEngine.UI;

namespace MidnightTestTask.Scripts.MainMenu.Volume
{
    public class VolumeEngineSettings : MonoBehaviour
    {
        [SerializeField] private Slider _volumeEngineSlider;
        private const string _volumeEngineKey = "VolumeEngine";

        private void Start()
        {
            if (PlayerPrefs.HasKey(_volumeEngineKey))
            {
                float savedVolume = PlayerPrefs.GetFloat(_volumeEngineKey);
                _volumeEngineSlider.value = savedVolume;
            }
        }
        
        public void UpdateVolume()
        {
            PlayerPrefs.SetFloat(_volumeEngineKey, _volumeEngineSlider.value);
            PlayerPrefs.Save();
        }
    }
}
