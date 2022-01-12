using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
    // Various canvas's that need to be hidden at first.
    public GameObject pauseMenuCanvas;

    public void PlayButton()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ReturnToGame()
    {
        Time.timeScale = 1;
        pauseMenuCanvas.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene("Settings Menu Scene");
    }
}
