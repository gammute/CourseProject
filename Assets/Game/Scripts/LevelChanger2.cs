using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sortitems
{
    public class LevelChanger2 : MonoBehaviour
    {
        
        [SerializeField] private GameObject _prefab;

        public GameObject[] _prefabs;

        public void go1() 
        {
            Instantiate (_prefabs[0], _prefabs[0].transform.position, Quaternion.identity);
            
        }

        public void destroy()
        {
            _prefabs = GameObject.FindGameObjectsWithTag("Level2");
            foreach (GameObject _prefab in _prefabs) 
            {
                        Destroy (_prefab);
            }
            
        }
    }
}
