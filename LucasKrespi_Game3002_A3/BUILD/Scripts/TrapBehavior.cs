using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehavior : MonoBehaviour
{

    private Rigidbody m_TrapRigidBody;
    [SerializeField]
    private float m_TorqueZaxis;
    // Start is called before the first frame update
    void Start()
    {
        m_TrapRigidBody = GetComponent<Rigidbody>();
        m_TorqueZaxis = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {

        m_TrapRigidBody.AddTorque(new Vector3(0.0f, 0.0f, m_TorqueZaxis));
    }
}
