using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    public bool PauseGame;

/*    public bool WinGame;*/

    public GameObject pauseGameMenu;

/*    public GameObject winGameMenu;*/



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

/*        if(Score.ScoreValue == 333)
        {
           if (WinGame)
            {
                
            }
            else
            {
                WinMenu();
            }
        }*/
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    /*    public void WinMenu()
        {
            winGameMenu.SetActive(true);
            Time.timeScale = 0f;
            WinGame = true;
        }*/

/*    public void CloseWinMenu()
    {
        winGameMenu.SetActive(false);
        Time.timeScale = 1f;
        WinGame = false;
    }*/

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Score.ScoreValue = 0;
    }

/*    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        winGameMenu.SetActive(false);
        WinGame = false;
        Score.ScoreValue = 0;
    }*/

    void LoadScene()
    {
      
    }
}
