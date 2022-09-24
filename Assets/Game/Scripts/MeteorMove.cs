using UnityEngine;

namespace Sortitems
{
    public class MeteorMove : MonoBehaviour
    {
       [SerializeField] private float _meteorSpeed;
       public GameObject _impactPrefab;
       private Rigidbody rb;

       private void Start() 
       {
            rb = GetComponent<Rigidbody>(); 
       }

       private void FixedUpdate() 
       {
            if (_meteorSpeed != 0 && rb != null)
            {
                rb.position += transform.forward * (_meteorSpeed * Time.deltaTime);
            } 
       }

       private void OnCollisionEnter(Collision collision) 
       {
            _meteorSpeed = 0;

            ContactPoint contact = collision.contacts[0];
            //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            //Vector3 pos = contact.point;

            if (_impactPrefab != null)
            {
                //var impactVFX = Instantiate(_impactPrefab, pos, rot) as GameObject;
                //Destroy(impactVFX, 5);
            }

            Destroy (gameObject);
       }
    }
}
