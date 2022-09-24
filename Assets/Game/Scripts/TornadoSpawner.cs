using UnityEngine;

namespace Sortitems
{
    public class TornadoSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Vector3 _range;
        [SerializeField] private float _minSpawnTime;
        [SerializeField] private float _maxSpawnTime;
        private float _time;
        private void Start() 
        {
            _time = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
        void Update()
        {
            if(_time <= 0)
            {
                Vector3 offset = new Vector3(Random.Range(-_range.x, _range.x), Random.Range(-_range.y, _range.y), Random.Range(-_range.z, _range.z));
                var obj = Instantiate(_prefab, transform.position + offset, Quaternion.identity);
                obj.transform.parent = transform;
                _time = Random.Range(_minSpawnTime, _maxSpawnTime);
            }
            _time -= Time.deltaTime;
        }
    }
}
