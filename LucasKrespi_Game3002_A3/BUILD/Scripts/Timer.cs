using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text m_TimerText;

    private float currentTime;
    private float initialTime;

    // Start is called before the first frame update
    void Start()
    {
        m_TimerText.GetComponent<Text>();
        initialTime = 120;
        currentTime = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        m_TimerText.text = currentTime.ToString("0");

        if(currentTime <= 60 && currentTime > 30)
        {
            m_TimerText.color = Color.yellow;
        }
        else if(currentTime <= 30)
        {
            m_TimerText.color = Color.red;
        }
        else
        {
            m_TimerText.color = Color.green;
        }

        if(currentTime <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
