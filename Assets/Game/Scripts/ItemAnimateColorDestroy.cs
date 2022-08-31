using System.Collections;
using UnityEngine;

namespace Sortitems
{
    public class ItemAnimateColorDestroy : MonoBehaviour
    {
        [SerializeField] private Color _destinationColor = Color.white;
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] float _animationTime = .3f; 

        private bool _isAnimate = false;
        private Material _itemMaterial;
        private Color _itemSrcColour;
        private float _elapsedTime;

        private void Awake() 
        {
            _itemMaterial = _meshRenderer.material;
            _itemSrcColour = _itemMaterial.color;    
        }

        public void Animate ()
        {
            if (_isAnimate)
            {
                return;
            }

            _isAnimate = true;

            _elapsedTime = 0f;

            StartCoroutine(AnimateColour());

        }

        protected IEnumerator AnimateColour()
        {
            while (_elapsedTime < _animationTime)
            {
                yield return new WaitForEndOfFrame();

                _itemMaterial.color = Color.Lerp(_itemSrcColour, _destinationColor, Mathf.PingPong(2*_elapsedTime/_animationTime, 1));

                _elapsedTime += Time.deltaTime;
            }

            _isAnimate = false;
            
            Destroy (this.gameObject);
        }
    }
}
