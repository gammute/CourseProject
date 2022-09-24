using UnityEngine;

namespace Sortitems
{
    public class MeteorExplosion : MonoBehaviour
    {
        [SerializeField] private float _power = 0f;
        [SerializeField] private float _radius;

        [SerializeField] private GameObject _explosionVFX;

        public void Explosion()
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, _radius);
            
            foreach (Collider hit in colliders)
            {
                Rigidbody _rb = hit.GetComponentInParent<Rigidbody>();

                if (_rb != null)
                {
                    _rb.AddExplosionForce(_power, explosionPos, _radius, 3.0f);
                }
            }
        }

        public void ExplosionVFX()
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
        }

        public void Destroyer()
        {
            Destroy(this.gameObject, 1);
        }
    }
}
