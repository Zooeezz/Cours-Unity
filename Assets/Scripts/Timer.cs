using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    int timeLeftConverted;
    UnityEngine.UI.Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 120;
        timerText = GameObject.Find("Timer").GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name=="SampleScene")
        {
            timeLeft -= Time.deltaTime;
            timeLeftConverted = (int)timeLeft;
            timerText.text = timeLeftConverted.ToString();
        }

    }
}