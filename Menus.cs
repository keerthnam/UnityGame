using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    private bool isPaused; // this false
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject winMenu;
    // Update is called once per frame
    void Update()
    {
      PauseMenu();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartCurrentScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
        Time.timeScale= 1.0f;
    }
    public void WinMenu()
    {
        winMenu.SetActive(true);
        Time.timeScale= 0f;
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale= 0f;
    }

    private void PauseMenu()
    {
        if (!isPaused)
        {
            // If the game isnt paused, it will pause. 
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else
        {
            // The game is already paused so it will unpause.
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPaused = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
