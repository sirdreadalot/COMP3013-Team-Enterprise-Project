using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthAndDamage : MonoBehaviour
{
    // Start is
    // called before the first frame update

    [SerializeField] public float Health;
    public Slider slider;
    private String Tag;
    private playerManager passToManager;
    [SerializeField] public bool HitByLightning;


    public void Lightningnest()
    {


        if (HitByLightning == false)
        {
            StartCoroutine(Lightning());
        }
        else { return; }


        

    }

    IEnumerator Lightning()
    {
        HitByLightning = true;


        yield return new WaitForSeconds(2);


        HitByLightning = false;

    }


    void Start()
    {
        HitByLightning = false;
        passToManager = FindObjectOfType<playerManager>();


        Debug.Log(slider);
        Tag = gameObject.tag;

        if (Tag == "Goblin")
        {
            Health = 100;
        }

        if (Tag == "Orc")
        {
            slider.maxValue = 200;
            Health = 200;
        }




    }

   

    // Update is called once per frame
    void Update()
    {

        slider.value = Health;

        if (Health <= 0)
        {
            if (Tag == "Goblin")
            {

                passToManager.addCoins(10);

            }
            if (Tag == "Orc")
            {

                passToManager.addCoins(20);

            }



            Destroy(gameObject);

        }

        
    }


 



    private void OnTriggerEnter2D(Collider2D collision)
    {



        

        //Check to see if the tag on the collider is equal to Arrow
        if (collision.tag == "Arrow")
        {

            if (Tag == "Goblin")
            {
                Health -= 50;
            }
            if (Tag == "Orc")
            {
                Health -= 25;
            }
            
            
            
           
           



        }
    }


}
