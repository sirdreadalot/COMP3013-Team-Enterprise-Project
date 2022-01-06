using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public playerManager script;
  
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Goblin")
        {
            script.damagePlayer(10);
            Destroy(collider.gameObject);
        }
    }
}
