using UnityEngine;

namespace MidnightTestTask.Scripts.Volume
{
    public class VolumeCarEngine : MonoBehaviour
    {
       [SerializeField] private AudioSource audioSource;
        
        private void Start()
        {
            GetSavedVolume();
        }

        private void GetSavedVolume()
        {
            if (PlayerPrefs.HasKey("VolumeEngine"))
            {
                audioSource.volume = PlayerPrefs.GetFloat("VolumeEngine");
            }
        }
    }
}
