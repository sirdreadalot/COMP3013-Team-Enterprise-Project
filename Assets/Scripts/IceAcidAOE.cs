using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAcidAOE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Goblin" || collision.tag == "Orc" || collision.tag == "Ogre" || collision.tag == "FireElemental" || collision.tag == "IceElemental" || collision.tag == "AcidElemental" || collision.tag == "LightningElemental")
        {


            collision.gameObject.GetComponent<healthAndDamage>().IceAcidAOE();

           
        }

    }


}
