using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sortitems
{
    public class AnimateVolumeWeight : MonoBehaviour
    {
        [SerializeField] private Volume _volume;
        [SerializeField] private float _animationTime = 0.3f;

        private bool _isAnimate = false;
        private float _elapsedTime;

        public void Animate()
        {
            if(_isAnimate)
            {
                return;
            }

            _isAnimate = true;

            _elapsedTime = 0f;

            StartCoroutine(AnimateVolume());
            
        }

        protected IEnumerator AnimateVolume()
        {
            while (_elapsedTime < _animationTime)
            {
                yield return new WaitForEndOfFrame();

                _volume.weight = Mathf.Sin(Mathf.PI * _elapsedTime / _animationTime);

                _elapsedTime += Time.deltaTime;
            }

            _isAnimate = false;
        }

        

    }
}
