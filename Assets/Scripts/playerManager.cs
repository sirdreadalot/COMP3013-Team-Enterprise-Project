using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{

    public int baseHealth = 100;
    public int playerCurrency = 10;

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Settings Menu Scene");
        }
    
    }

}
