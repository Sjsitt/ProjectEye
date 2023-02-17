using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void PlayGame4()
    {
        SceneManager.LoadScene("Level12");
    }
    public void ExitGame()
    {
        Debug.Log("Game Exit");

        Application.Quit();
    }


}
