using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePlayer : MonoBehaviour
{

    public playerManager script;
  
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (script.playerCurrentHealth > 0)
        {
            if (collider.gameObject.tag == "Goblin")
            {
                script.damagePlayer(5);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "Ogre")
            {
                script.damagePlayer(10);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "Orc")
            {
                script.damagePlayer(10);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "IceElemental")
            {
                script.damagePlayer(20);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "AcidElemental")
            {
                script.damagePlayer(20);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "FireElemental")
            {
                script.damagePlayer(20);
                Destroy(collider.gameObject);
            }

            if (collider.gameObject.tag == "LightningElemental")
            {
                script.damagePlayer(20);
                Destroy(collider.gameObject);
            }
        }
        else
        {
            SceneManager.LoadScene("Game Over Scene");
        }
    }
}
