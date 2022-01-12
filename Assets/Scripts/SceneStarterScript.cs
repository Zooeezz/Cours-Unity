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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        finalKillCount.text = kCS.killCountConverted.ToString();
    }
}
