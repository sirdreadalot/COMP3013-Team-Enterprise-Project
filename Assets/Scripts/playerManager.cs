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
    public int playerCurrency = 0;

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenuCanvas.SetActive(true);
        }
    
    }


    public void addCoins( int coinsToAdd)
    {

        playerCurrency += coinsToAdd;

    }


}
