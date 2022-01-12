using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    Timer timerScript;
    bool hasEndSceneLoaded;
    public static SceneChanger instance; 

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(gameObject);
        timerScript = GetComponent<Timer>();
        hasEndSceneLoaded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerScript.timeLeft<=0 && hasEndSceneLoaded==false)
        {
            SceneManager.LoadScene("GameOverScene");
            hasEndSceneLoaded = true;
        }
    }
}
