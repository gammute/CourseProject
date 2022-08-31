using UnityEngine;

namespace Sortitems
{
    public class CharacterAnimationPlayer : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        //private void Start() {PlaySad();}
        
        public void PlaySilly()
        {
            _animator.SetTrigger(name:"PlaySilly");
        }

        public void PlaySad()
        {
            _animator.SetTrigger(name:"PlaySad");
            Debug.Log("anim");
        }
    }
}
