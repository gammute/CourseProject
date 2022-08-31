using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sortitems
{
    public class LevelChanger : MonoBehaviour
    {
        
        [SerializeField] private GameObject _prefab;

        public void go1() 
        {
            Instantiate (_prefab, _prefab.transform.position, Quaternion.identity);
            
        }

        public void destroy()
        {
            Destroy (GameObject.FindGameObjectWithTag("Level1"));
            
        }
    }
}
