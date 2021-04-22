using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //quit Application
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();

        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "player")
        {
         SceneManager.LoadScene(1);
        }
    }
}
