using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraBehavior : MonoBehaviour
{
    //Camera physics
    private SpringJoint m_SpringArm;
    [SerializeField]
    private Rigidbody m_CameraRegidBody;
    private float m_SpringArmDist;

    //Player info
    [SerializeField]
    private Rigidbody m_Player;
 
    //Forces
    [SerializeField]
    private float m_MoveCameraForce;

    void Start()
    {
      
        m_SpringArm = GetComponent<SpringJoint>();
        m_CameraRegidBody = GetComponent<Rigidbody>();


       m_MoveCameraForce = 100.0f;
       m_SpringArmDist = -40.0f;
    }

    void Update()
    {
        //If the Player velocity you can see a little further up and down
        if (m_Player.velocity.magnitude == 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                m_CameraRegidBody.AddForce(0.0f, m_MoveCameraForce, 0.0f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                m_CameraRegidBody.AddForce(0.0f, -m_MoveCameraForce, 0.0f);
            }
        }
        else
        {
            m_SpringArm.connectedAnchor = m_Player.transform.position + new Vector3(0.0f, 2.0f, m_SpringArmDist);
        }
    }
}
