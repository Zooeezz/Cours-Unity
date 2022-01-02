using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        timerScript = GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerScript.timeLeft<=0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
