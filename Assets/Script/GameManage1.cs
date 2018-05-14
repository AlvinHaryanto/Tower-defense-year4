using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage1 : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;

     void Update()
    {
        if (gameEnded)
            return;

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }




    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GameOver");
            //Invoke("Restart", restartDelay);
            SceneManager.LoadScene("RealMainmenu");
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
