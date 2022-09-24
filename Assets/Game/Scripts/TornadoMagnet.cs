using System.Collections;
using UnityEngine;

namespace Sortitems
{
    public class TornadoMagnet : MonoBehaviour
    {
        [SerializeField] private Transform TornadoCenter;
        [SerializeField] private float pullForce;
        [SerializeField] private float refreshRate;


        private void OnTriggerEnter(Collider other) 
        {
            if(other.tag == "ojb")
            {
                StartCoroutine(pullObject(other, true));
            }

        }

        private void OnTriggerExit(Collider other) 
        {
            if(other.tag == "ojb")
            {
                StartCoroutine(pullObject(other, false));
            }
        }

        IEnumerator pullObject(Collider x, bool shoudPull)
        {
            if(x != null)
            {
                Vector3 ForceDir = TornadoCenter.position - x.transform.position;
                x.GetComponentInParent<Rigidbody>().AddForce(ForceDir.normalized * pullForce * Time.deltaTime);
            }
            yield return refreshRate;
            StartCoroutine(pullObject(x, shoudPull));
        }
    }
}
