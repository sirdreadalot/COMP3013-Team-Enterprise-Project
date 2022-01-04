using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
  
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Goblin")
        {
            
            Destroy(collider.gameObject);
        }
    }
}
