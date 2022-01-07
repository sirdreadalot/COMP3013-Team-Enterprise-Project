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
    private String Tag; //script is shared between enemies so this lets parts of code know what type of enemies its on
    private playerManager passToManager; //allows connection of the scripts


    [Header("Hit by elements")]
    [SerializeField] public bool HitByLightning = false;
    [SerializeField] public bool HitByAcid = false;                 //These are for testing purposes and allow us to see which element has hit the target
    [SerializeField] public bool HitByFire = false;
    [SerializeField] public bool HitByIce = false;


    [Header("Active Elemental Effects")]

    [SerializeField] public bool twoBoolsActive = false; //is there an effect active
    [SerializeField] public bool LightningFireDamage = false;           
   [SerializeField] public bool IceFireDamage = false;              //which effect is active
    [SerializeField] public bool AcidFireDamage = false;






    void Start()
    {
 
        passToManager = FindObjectOfType<playerManager>();
      
        Tag = gameObject.tag;  //gets tag of gameObject

        if (Tag == "Goblin")
        {
            Health = 10000;
           
        }

        if (Tag == "Orc")
        {                                           //sets health of enemies. slider max value is also set        
            Health = 300;
            
        }
        if (Tag == "Ogre")
        {          
            Health = 500;
            
        }

        slider.maxValue = Health;


    }




    // Update is called once per frame
    void Update()
    {


       

        slider.value = Health; //once damage is done the slider updates on the next frame


        StartCoroutine(ElementMixing()); //checks to see if any elemental mixing statements are valid -> damage for them are done in the method

        if (LightningFireDamage == true)
        {
            Health -= 0.01f;          // lightning damage work differently in that it hurts over time. if the effect sets LightningFireDamage to true for x seconds update will add that to damage each frame
        }
     

        if (HitByLightning == true)  //lightning damage work differently in that it hurts over time. while its being targeted and hit itll hurt, this is why lightning damage appears in update
        {

            if (Tag == "Goblin")
            {

                Health -= 0.05f;
               


            }
            if (Tag == "Orc")
            {

                Health -= 0.15f;   //Orcs are set to take more lightning damage
                

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

                passToManager.addCoins(20);             //adds coins for each enemy death. the bigger the enemy (in descending order here) the more dollar gotten

            }
            if (Tag == "Ogre")
            {

                passToManager.addCoins(30);

            }



            Destroy(gameObject);

        }

        
    }
    

    // Elemental damage works starting with the projectile. the projectile script will have its own tag depending on the prefab its instantiating.
    // once they collide (enemy + projectile) it calls upon nested methods here in the healthanddamage script to deal the damage.
    // the nested statments call the repective couroutines that say the target was hit by the specific element that set true for a certain amount of time.
    // the times are being balanced, the smaller the time and elements has to remain true the smaller the chance other elements have to hit the same target and activate the element mixing statments.
   

    /// //////////////////LIGHTNING DAMAGE/////////////////////////////////////////
    
    public void LightningNest()
    {


        if (HitByLightning == false )   //if its already hit then theres no need to trigger the couroutine
        {
            StartCoroutine(Lightning());    //makes it so if it is now recognised its hit by lightning
        }
        else { return; }


    }

   

    IEnumerator Lightning()
    {
        HitByLightning = true;


        yield return new WaitForSeconds(0.5f);      //the wait for seconds is so other elements have a chance to also get recognised so elemental mixing statements can get triggered


        HitByLightning = false; 

    }
   
    /// ///////////////////////FIRE DAMAGE/////////////////////////////////////////////////
   
    public void FireNest()
    {


        if (HitByFire == false )        //if fire nest is called while is already recgonised its hit by fire we can skip calling the couroutine that recognises it again and move onto damage
        {
            StartCoroutine(Fire());
        }
        

        if (HitByFire == true) //only do damage if the target is hit
        {

            if (Tag == "Goblin")
            {

                Health -= 50f;      //goblins take more fire damage



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


        yield return new WaitForSeconds(0.5f);      //the element of fire is recognised on this target for the waitforseconds time count.
                                                                


        HitByFire = false;

    }



/// ////////////////////////////ICE DAMAGE///////////////////////////////////////


    public void IceNest()
    {


        if (HitByIce == false )
        {
            StartCoroutine(Ice());
        }
        

        if (HitByIce == true)
        {

            if (Tag == "Goblin")
            {

                Health -= 10f;

                

            }
            if (Tag == "Orc")
            {                                           //ice damage is constistant

                Health -= 10f;


            }
            if (Tag == "Ogre")
            {

                Health -= 10f;

                

            }

            Follow FollowIce = GetComponent<Follow>();          //the purpose of ice towers are to slow enemies, this reduces the speed modifier in the Follow script
            FollowIce.speedModifier = 0.2f;


        }
        




    }


    IEnumerator Ice()
    {
        HitByIce = true;


       

        yield return new WaitForSeconds(1);

        Follow FollowIce = GetComponent<Follow>();
        FollowIce.speedModifier = 0.5f;

        HitByIce = false;

    }


    
    /// ////////////////////////////ACID DAMAGE//////////////////////////////////////
    


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

                Health -= 100f;                     //larger enemies take more acid damage


            }


        }


    }

    IEnumerator Acid()
    {
        HitByAcid  = true;


        yield return new WaitForSeconds(0.5f);


        HitByAcid = false;

    }


    // elemental mixing happens when 2 of the "Hit by elements" bools become true and the target hasnt already got an effect on it.
   


    IEnumerator ElementMixing()
    {

        if (Tag == "Goblin" && HitByFire == true && HitByIce == true && twoBoolsActive == false)        //small enemies take this sort of extra damage
        {
            twoBoolsActive = true;
            IceFireDamage = true;
            Health -= 50;
            yield return new WaitForSeconds(0.5f);              //does an extra 50 damage straight away
            twoBoolsActive = false;
            IceFireDamage = false;
        }

        /////////////////////////////////////////////

        if (HitByFire == true && HitByLightning == true && twoBoolsActive == false)  //fire and lightning mix hits all targets
        {
            twoBoolsActive = true;


            Follow Follow = GetComponent<Follow>();
            Follow.speedModifier = 0;
            LightningFireDamage = true;         //adds extra lighning damage, damage is added in update()


            yield return new WaitForSeconds(2);     //stuns (sets movement speed) to 0

            Follow.speedModifier = 0.5f;         //sets it back to normal



            yield return new WaitForSeconds(2);
            LightningFireDamage = false;            //stops extra damage
            twoBoolsActive = false;         //allows for another effect to happen
        }

        /////////////////////////////////////////////////

        if (Tag == "Ogre" || Tag == "Orc")      //only medium enemies take this effect
        {

            if (HitByFire == true && HitByIce == true && twoBoolsActive == false)
            {
                twoBoolsActive = true;
                AcidFireDamage = true;
                Health -= 100;                              //takes extra damage straight away
                yield return new WaitForSeconds(0.5f);
                twoBoolsActive = false;
                AcidFireDamage = false;
            }

        }

        //////////////////////////////////////////////////////////


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
