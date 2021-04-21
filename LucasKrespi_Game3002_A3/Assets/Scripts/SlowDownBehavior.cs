using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public class BoucePlataformBehavior : MonoBehaviour
    {
        // Start is called before the first frame update
    
        private void OnTriggerEnter(Collider other)
        {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
