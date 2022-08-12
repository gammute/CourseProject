using UnityEngine;

namespace Sortitems
{
    public class GetterSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _count;
        [SerializeField] private Vector3 _range;
        void Start()
        {
            
            Vector3 offset = new Vector3(_range.x, _range.y,_range.z);
                var obj = Instantiate(_prefab, transform.position + offset, Quaternion.identity);
                obj.transform.parent = transform;
            
            
        }
    }
}
