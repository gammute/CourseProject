using UnityEngine;

namespace Sortitems
{
    public class LevelChanger : MonoBehaviour
    {
        
        [SerializeField] private GameObject _prefab;

        public void SpawnLevel() 
        {
            Instantiate (_prefab, _prefab.transform.position, Quaternion.identity);
            
        }

        public void DestroyLevel()
        {
            Destroy (this.gameObject);
            
        }
    }
}
