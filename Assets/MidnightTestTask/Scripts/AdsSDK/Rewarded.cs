using UnityEngine;

namespace MidnightTestTask.Scripts.AdsSDK
{
    public class Rewarded : MonoBehaviour
    {
        public string appkey;
        
        private void Start()
        {
            IronSource.Agent.shouldTrackNetworkState(true);
            IronSourceEvents.onRewardedVideoAvailabilityChangedEvent += RewardedVideoAvailabilityChangedEvent;
            IronSourceEvents.onRewardedVideoAdClosedEvent += RewardedVideoAdClosedEvent;
        }
        
        public void RewardedButton()
        {
            IronSource.Agent.showRewardedVideo();
        }

        void RewardedVideoAdClosedEvent()
        {
            IronSource.Agent.init(appkey, IronSourceAdUnits.REWARDED_VIDEO);
            IronSource.Agent.shouldTrackNetworkState(true);
            
        }

        void RewardedVideoAvailabilityChangedEvent(bool available)
        {
            bool rewardedVideoAvailability = available;
        }
    }
}