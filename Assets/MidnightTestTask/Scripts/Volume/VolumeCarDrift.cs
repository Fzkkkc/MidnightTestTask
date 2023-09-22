using UnityEngine;

namespace MidnightTestTask.Scripts.Volume
{
    public class VolumeCarDrift : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        
        private void Start()
        {
            GetSavedVolume();
        }

        private void GetSavedVolume()
        {
            if (PlayerPrefs.HasKey("VolumeDrift"))
            {
                audioSource.volume = PlayerPrefs.GetFloat("VolumeDrift");
            }
        }
    }
}