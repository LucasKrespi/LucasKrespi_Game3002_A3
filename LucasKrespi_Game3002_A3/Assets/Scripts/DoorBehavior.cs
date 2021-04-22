using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Door;
    private HingeJoint m_Hinge;
    private float m_closedPos;
    private float m_openPos;

    private bool m_openDoor;
    private bool m_playerHasKey;
    // Start is called before the first frame update
    void Start()
    {
    
        m_closedPos = 0.0f;
        m_openPos = -90.0f;

        if(m_Door.name == "Cube (1)")
        {
            m_openPos = 90.0f;
        }
        m_Hinge = GetComponent<HingeJoint>();
        m_Hinge.useSpring = true;
        m_openDoor = false;
        m_playerHasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = 1000;
        spring.damper = 150;

        if (Input.GetKeyDown(KeyCode.P) && m_playerHasKey)
        {
            m_openDoor = true;
        }
        if (m_openDoor)
        {
            spring.targetPosition = m_openPos;
        }
        else
        {
            spring.targetPosition = m_closedPos;
        }

        m_Hinge.spring = spring;
        m_Hinge.useLimits = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "player")
        {
            m_playerHasKey = other.GetComponent<PlayerBehavior>().getHasKey(); 
        }
    }
}
