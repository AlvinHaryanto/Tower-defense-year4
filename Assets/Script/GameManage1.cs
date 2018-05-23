using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage1 : MonoBehaviour
{
    public static bool GameIsOver;
    public float restartDelay = 1f;
    public GameObject gameOverUI;

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

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
