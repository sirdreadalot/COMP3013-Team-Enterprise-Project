using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
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
        SceneManager.LoadScene("Main Menu Scene");
    }
    
    public void SettingsMenu()
    {
        SceneManager.LoadScene("Settings Menu Scene");
    }
}
