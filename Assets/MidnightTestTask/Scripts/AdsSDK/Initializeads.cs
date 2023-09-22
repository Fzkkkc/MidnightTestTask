using UnityEngine;

namespace MidnightTestTask.Scripts.AdsSDK
{
    public class Initializeads : MonoBehaviour
    {
        public string appKey;
        
        private void Awake()
        {
            IronSource.Agent.init(appKey);
        }

        private void Start()
        {
            Loadbanner();
        }

        void OnApplicationPause(bool isPaused)
        {
            IronSource.Agent.onApplicationPause(isPaused);
        }

        public void Loadbanner()
        {
            IronSource.Agent.loadBanner(IronSourceBannerSize.BANNER, IronSourceBannerPosition.BOTTOM);
        }
    }
}
