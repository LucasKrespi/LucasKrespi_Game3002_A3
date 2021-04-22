using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    //Physics Body
    private Rigidbody m_PlayerRigidbody;

    //Forces
    [SerializeField]
    private float m_groundLocomotionForce;
    [SerializeField]
    private float m_AirLocomotionForce;
    [SerializeField]
    private float m_JumpForce;

    //Booleans
    public bool m_isGrounded;
    private bool m_hasKey;



    void Start()
    {
        //Get Components
        m_PlayerRigidbody = GetComponent<Rigidbody>();

        //Inicialize Variables
        m_groundLocomotionForce = 8.0f;
        m_AirLocomotionForce = 2.0f;
        m_JumpForce = 200;
        m_isGrounded = false;
        m_hasKey = false;
    }

   
    void Update()
    {
        if(m_isGrounded)
        {

            if (Input.GetKey(KeyCode.A))
            {
                m_PlayerRigidbody.AddForce(-m_groundLocomotionForce, 0.0f, 0.0f);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                m_PlayerRigidbody.AddForce(m_groundLocomotionForce, 0.0f, 0.0f);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_PlayerRigidbody.AddForce(0.0f, m_JumpForce, 0.0f);
                m_isGrounded = false;
            }
        }
        else
        {
            //player move slower on air so it cant fly trough the obstacles
            if (Input.GetKey(KeyCode.A))
            {
                m_PlayerRigidbody.AddForce(-m_AirLocomotionForce, 0.0f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                m_PlayerRigidbody.AddForce(m_AirLocomotionForce, 0.0f, 0.0f);
            }
        }

    }

    //Reset Jump on collision so the player can climb walls
    private void OnCollisionEnter(Collision collision)
    {
        m_isGrounded = true;
    }

    public bool getHasKey()
    {
        return m_hasKey;
    }
    public void setHasKey(bool hasKey)
    {
        m_hasKey = hasKey;
    }
}
