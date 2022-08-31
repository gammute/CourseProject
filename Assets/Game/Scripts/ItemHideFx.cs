using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class ItemHideFx : MonoBehaviour
    {
    [SerializeField] private VFXPoolProvider _vfxPoolProvider;

    public UnityEvent OnClick;

     public void Hide()
     {
        VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
        poolItem.transform.position = transform.position;
        poolItem.ParticleSystem.Play();

        OnClick.Invoke();

        //Destroy(this.gameObject);
     }
    }
}
