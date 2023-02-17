using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChanger2 : MonoBehaviour
{

    public bool WinGame;

    public GameObject winGameMenu;

    public int ScoreVal5;

    void Update()
    {
        if (Score.ScoreValue == ScoreVal5)
        {
            if (WinGame)
            {

            }
            else
            {
                WinMenu();
            }
        }
    }

    public void WinMenu()
    {
        winGameMenu.SetActive(true);
        Time.timeScale = 0f;
        WinGame = true;
    }

    public void NextLevel()
    {
        winGameMenu.SetActive(false);
        WinGame = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Score.ScoreValue = 0;
    }

    public void CloseWinMenu()
    {
        winGameMenu.SetActive(false);
        Time.timeScale = 1f;
        WinGame = false;
    }
}
