using UnityEngine;
using UnityEngine.EventSystems;

namespace Sortitems
{
    public class DragItem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        [SerializeField] private float upForce = 50f;

        private Rigidbody _rigidbody;

        public bool isDraggble {get; private set;}

        [SerializeField] private ItemType _type;
        public ItemType Type { get => _type; }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            if(isDraggble == false)
                return;

            if(!eventData.pointerCurrentRaycast.isValid)
            {
                _rigidbody.isKinematic = false;
                isDraggble = false;

                return;
            }
            var pos = eventData.pointerCurrentRaycast.worldPosition;
            var delta = pos - transform.position;
            delta.y = 0;

            transform.position += delta;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _rigidbody.isKinematic = true;
            isDraggble = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if(isDraggble == false)
                return;
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(Vector3.up * upForce);
            isDraggble = false;
        }
    }
}
