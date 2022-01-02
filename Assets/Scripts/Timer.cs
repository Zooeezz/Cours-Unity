using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("Time out !");
        }
        timeLeftConverted = (int)timeLeft;
        timerText.text = timeLeftConverted.ToString();
    }
}