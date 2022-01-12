using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerManager : MonoBehaviour
{
    // Various canvas's that need to be hidden at first.
    public GameObject pauseMenuCanvas;


    // Various public variables.
    public Slider healthbar;
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public int playerCurrency = 0;

    void Start()
    {
        playerMaxHealth = 100;
        playerCurrentHealth = playerMaxHealth;
        healthbar.maxValue = playerMaxHealth;
        healthbar.value = playerMaxHealth;
    }

    void Update()
    {
        // Allows the player to pause time by accessing the pause menu when pressing the 'esc' key.
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

    public void removeCoins(int coinsToRemove)
    {
        playerCurrency -= coinsToRemove;
    }

    public void damagePlayer(int damage)
    {
        playerCurrentHealth = playerCurrentHealth - damage;
        healthbar.value = playerCurrentHealth;
    }
}
