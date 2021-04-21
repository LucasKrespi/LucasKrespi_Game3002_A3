using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoucePlataformBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 m_OnTriggerForce;

    private void Start()
    {
        m_OnTriggerForce = new Vector3(300.0f, 300.0f, 0.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(m_OnTriggerForce);
    }
}
