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


    [Header("Hit by elements")]
    [SerializeField] public bool HitByLightning = false;
    [SerializeField] public bool HitByAcid = false;
    [SerializeField] public bool HitByFire = false;
    [SerializeField] public bool HitByIce = false;


    [Header("Active Elemental Effects")]

    [SerializeField] public bool twoBoolsActive = false;
    [SerializeField] public bool LightningFireDamage = false;


    [SerializeField] public bool IceFireDamage = false;







    void Start()
    {
        HitByLightning = false;
        passToManager = FindObjectOfType<playerManager>();
      
        Tag = gameObject.tag;

        if (Tag == "Goblin")
        {
            Health = 10000;
            slider.maxValue = 10000;
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



    IEnumerator ElementMixing()
    {

        if (Tag == "Goblin" && HitByFire == true && HitByIce ==true && twoBoolsActive == false)
        {
            twoBoolsActive = true;
            IceFireDamage = true;
            Health -= 50;
            yield return new WaitForSeconds(0.5f);
            twoBoolsActive = false;
            IceFireDamage = false;
        }

        if (HitByFire == true && HitByLightning == true && twoBoolsActive == false)
        {
            twoBoolsActive = true;


            Follow Follow = GetComponent<Follow>();
            Follow.speedModifier = 0;
            LightningFireDamage = true;


            yield return new WaitForSeconds(2);

            Follow.speedModifier = 0.5f;
            


            yield return new WaitForSeconds(2);
            LightningFireDamage = false;
            twoBoolsActive = false;
        }






    }





    // Update is called once per frame
    void Update()
    {


       

            slider.value = Health;
        StartCoroutine(ElementMixing());

        if (LightningFireDamage == true)
        {
            Health -= 0.01f;
        }
     

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


        if (HitByLightning == false )
        {
            StartCoroutine(Lightning());
        }
        else { return; }


    }

   

    IEnumerator Lightning()
    {
        HitByLightning = true;


        yield return new WaitForSeconds(0.5f);


        HitByLightning = false;

    }

    public void FireNest()
    {


        if (HitByFire == false )
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


        yield return new WaitForSeconds(0.5f);


        HitByFire = false;

    }

    public void IceNest()
    {


        if (HitByIce == false )
        {
            StartCoroutine(Ice());
        }
        else { return; }

        if (HitByIce == true)
        {

            if (Tag == "Goblin")
            {

                Health -= 10f;

                //half speed

            }
            if (Tag == "Orc")
            {

                Health -= 10f;

                //half speed

            }
            if (Tag == "Ogre")
            {

                Health -= 10f;

                //half speed

            }




        }
        




    }


    IEnumerator Ice()
    {
        HitByIce = true;


        Follow Follow = GetComponent<Follow>();
        Follow.speedModifier = 0.2f;
        LightningFireDamage = true;

        yield return new WaitForSeconds(1);

        Follow.speedModifier = 0.5f;

        HitByIce = false;

    }

    public void AcidNest()
    {
        if (HitByAcid == false )
        {
            StartCoroutine(Acid());
        }
        else { return; }




        if (HitByAcid == true)
        {

            if (Tag == "Goblin")
            {

                Health -= 25f;



            }
            if (Tag == "Orc")
            {

                Health -= 25f;



            }
            if (Tag == "Ogre")
            {

                Health -= 100f;


            }


        }


    }

    IEnumerator Acid()
    {
        HitByAcid  = true;


        yield return new WaitForSeconds(0.5f);


        HitByAcid = false;

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
