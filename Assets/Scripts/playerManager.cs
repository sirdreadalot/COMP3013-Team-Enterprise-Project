using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{
    // Various canvas's that need to be hidden at first.
    public GameObject pauseMenuCanvas;

    // Various public variables.
    public int baseHealth = 100;
    public int playerCurrency = 10;

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            pauseMenuCanvas.SetActive(true);
        }
    
    }

}
