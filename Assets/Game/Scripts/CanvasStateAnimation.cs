using UnityEngine;

namespace Sortitems
{
    public class CanvasStateAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        public void PlayOpen()
        {
            _animator.SetTrigger(name:"Open");
        }

        public void PlayClose()
        {
            _animator.SetTrigger(name:"Close");
        }
    }
}
