using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneStarterScript : MonoBehaviour
{
    UnityEngine.UI.Text finalKillCount;
    KillCount kCS;
        
    void Start()
    {
        finalKillCount = GameObject.Find("EnemiesKilledCount").GetComponent<UnityEngine.UI.Text>();
        kCS = GameObject.Find("GameManager").GetComponent<KillCount>();
    }

    // Update is called once per frame
    void Update()
    {
        finalKillCount.text = kCS.killCountConverted.ToString();

        if(Input.GetButtonDown("Fire1"))
        {
            Application.Quit();
        }

    }
}
