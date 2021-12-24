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
    [SerializeField] public bool HitByLightning = false;
    [SerializeField] public bool HitByAcid = false;
    [SerializeField] public bool HitByFire = false;
    [SerializeField] public bool HitByIce = false;

    [SerializeField] public bool twoBoolsActive = false;





    void Start()
    {
        HitByLightning = false;
        passToManager = FindObjectOfType<playerManager>();
      
        Tag = gameObject.tag;

        if (Tag == "Goblin")
        {
            Health = 100;
        }

        if (Tag == "Orc")
        {
            slider.maxValue = 300;
            Health = 300;
        }
        if (Tag == "Ogre")
        {
            slider.maxValue = 500;
            Health = 500;
        }




    }

   

    // Update is called once per frame
    void Update()
    {

        slider.value = Health;


        if (HitByLightning == true)
        {

            if (Tag == "Goblin")
            {

                Health -= 0.05f;
               


            }
            if (Tag == "Orc")
            {

                Health -= 0.15f;
                

            }
            if (Tag == "Ogre")
            {

                Health -= 0.05f;


            }


        }


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
            if (Tag == "Ogre")
            {

                passToManager.addCoins(30);

            }



            Destroy(gameObject);

        }

        
    }

    public void LightningNest()
    {


        if (HitByLightning == false && twoBoolsActive == false)
        {
            StartCoroutine(Lightning());
        }
        else { return; }


    }

   

    IEnumerator Lightning()
    {
        HitByLightning = true;


        yield return new WaitForSeconds(1);


        HitByLightning = false;

    }

    public void FireNest()
    {


        if (HitByFire == false && twoBoolsActive == false)
        {
            StartCoroutine(Fire());
        }
        

        if (HitByFire == true)
        {

            if (Tag == "Goblin")
            {

                Health -= 50f;



            }
            if (Tag == "Orc")
            {

                Health -= 25f;



            }
            if (Tag == "Ogre")
            {

                Health -= 25f;


            }


        }

    }


    IEnumerator Fire()
    {
        HitByFire = true;


        yield return new WaitForSeconds(1);


        HitByFire = false;

    }

    public void IceNest()
    {


        if (HitByIce == false && twoBoolsActive == false)
        {
            StartCoroutine(Ice());
        }
        else { return; }


    }


    IEnumerator Ice()
    {
        HitByIce = true;


        yield return new WaitForSeconds(1);


        HitByIce = false;

    }

    IEnumerator AcidNest()
    {
        HitByAcid = true;


        yield return new WaitForSeconds(1);


        HitByAcid = false;

    }

    IEnumerator Acid()
    {
        HitByIce = true;


        yield return new WaitForSeconds(1);


        HitByIce = false;

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
            if (Tag == "Ogre")
            {
                Health -= 25;
            }









        }
    }


}
