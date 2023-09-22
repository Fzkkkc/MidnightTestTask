using UnityEngine;

namespace MidnightTestTask.Scripts.UI.Transition
{
    public class TransitionAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _transitionAnimator;

        public void ShowTransitionAnimation()
        {
            _transitionAnimator.SetTrigger("ShowTransitionAnimation");
        }
    }
}
