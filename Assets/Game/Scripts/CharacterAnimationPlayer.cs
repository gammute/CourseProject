using UnityEngine;

namespace Sortitems
{
    public class CharacterAnimationPlayer : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        public void PlaySilly()
        {
            _animator.SetTrigger(name:"PlaySilly");
        }

        public void PlaySad()
        {
            _animator.SetTrigger(name:"PlaySad");
        }

        public void PlayWalk()
        {
            _animator.SetTrigger(name:"PlayWalk");
        }
    }
}
