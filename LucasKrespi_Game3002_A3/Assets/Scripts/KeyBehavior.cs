using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    private Rigidbody m_KeyRigidBody;
    [SerializeField]
    private GameObject m_Key;
    void Start()
    {
        m_KeyRigidBody = GetComponent<Rigidbody>();
        m_KeyRigidBody.AddTorque(new Vector3(0.0f,50.0f,0.0f));
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(m_Key);

        if(other.gameObject.name == "player")
        {
            other.GetComponent<PlayerBehavior>().setHasKey(true);
        }
    }
}
