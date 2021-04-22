using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownBehavior : MonoBehaviour
{
    // slow down the player after the bounce part
   
    
    private void OnTriggerEnter(Collider other)
    {
      other.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    
}
