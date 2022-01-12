using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    string currentScene;
    KillCount kCS;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = "None";
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (Input.GetButtonDown("Fire1") && currentScene == "Menu")
        {
            LoadGameScene();
        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
        kCS.killCount = 0;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exitting game...");
    }
}
