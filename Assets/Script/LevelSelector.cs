using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {

    public Button[] levelButtons;

   

    public void LevelSatu()
    {
        SceneManager.LoadScene("Level01");
        

    }

    public void LevelDua()
    {
        SceneManager.LoadScene("Level02");

    }

    public void LevelTiga()
    {
        SceneManager.LoadScene("Level03");

    }

    public void LevelEmpat()
    {
        SceneManager.LoadScene("Level04");

    }

    public void LevelInfinity()
    {
        SceneManager.LoadScene("TowerDefense");

    }

}

