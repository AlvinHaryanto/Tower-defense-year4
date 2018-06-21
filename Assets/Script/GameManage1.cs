using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage1 : MonoBehaviour
{
    
    public float restartDelay = 1f;
    public static bool GameIsOver;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;


    void Start()
    {
        GameIsOver = false;
    }


    void Update()
    {
        if (GameIsOver)
            return;

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }


    }



    public void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {

        GameIsOver = true;
        completeLevelUI.SetActive(true);
        Debug.Log("Abis");
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
