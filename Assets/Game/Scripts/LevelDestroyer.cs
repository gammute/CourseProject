using UnityEngine;

namespace Sortitems
{
    public class LevelDestroyer : MonoBehaviour
    {
        public void DestroyLevel()
        {
            Destroy(GameObject.FindWithTag("Level"));
        }
    }
}
