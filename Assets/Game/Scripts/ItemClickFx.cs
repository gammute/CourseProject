using UnityEngine;
using UnityEngine.EventSystems;

namespace Sortitems
{
    public class ItemClickFx : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;

        public void OnPointerDown(PointerEventData eventData)
        {
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();
        }
    }
}
