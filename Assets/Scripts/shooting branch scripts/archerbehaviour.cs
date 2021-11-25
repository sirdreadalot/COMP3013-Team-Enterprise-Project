using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class archerbehaviour : MonoBehaviour
{



   
    [Header("targeting behaviour")]
   
    [SerializeField] private List<GameObject> targetlist = new List<GameObject>(); //will store all enemies in give collision radius   
    [SerializeField]  GameObject Target;  //store gameobject for current target
    [SerializeField] private float closestEnemy = 0;   //stores closest distance from gameobject to this
    [SerializeField] private float newdDist = 0;  //stores individual gameobject distances


    [Header("arrow generation")]

    public GameObject arrow;
    public Transform firepoint;
    public Vector3 targetposition;
    [SerializeField] Transform Targetposition;



    [Header("Reloading")]

    private float reloadTime = 1f;
    public int maxAmmo = 1;
    private int CurrentAmmo;
    private bool isreloading = false;


    // Start is called before the first frame update
    void Start()
    {
        CurrentAmmo = maxAmmo;



    }

    // Update is called once per frame
    void Update()
    {

        if (isreloading)
        {
            return;
        }

        //if(closesttarget == on)

        if (CurrentAmmo <=0)
        {
            StartCoroutine(reload());
            return;
        }

        if (targetlist != null)
        {

            firArrow();
           

        }

           

        //if(targetfirst == on)
        //Target = targetlist[0];

        //if(targetLast == on)
        //Target = targetlist.LastOrDefault();





    }



   


    IEnumerator reload()
    {

        isreloading = true;

        yield return new WaitForSeconds(reloadTime);

        CurrentAmmo = maxAmmo;
        Debug.Log("reloading");

        isreloading = false;

    }

    public Transform targetclosest()
    {


        if (targetlist.Count() == 0)
        {
            Target = null;
            closestEnemy = 0;               //resets values when there are no targets and stops it hitting the for loop
            newdDist = 0;
        }
        else
        if (targetlist.Count() != 0)
        {

            closestEnemy = Vector2.Distance(this.transform.position, targetlist[0].transform.position); //if there is no enemies and one enters, this becomes the closest enemey


            for (int i = 0; i < targetlist.Count(); i++)
            {

                newdDist = Vector2.Distance(this.transform.position, targetlist[i].transform.position);    //for each frame the targetlist is evaluated and stores the Ith gameobjects distance from the tower




                if (newdDist <= closestEnemy)       //compares the previous distance (closestEnemy) to the new one found and stored in newdist. will pass if the newdist is smaller than the previous distance caught
                {

                    Target = targetlist[i];     //sets the new target to the gameobject found to be closer
                    newdDist = closestEnemy;     //sets the new benchmark to beat for the next game object
                    

                }


            }



            Targetposition = Target.transform;   //get the position of the target

            return Targetposition;   //method returns target position

        }



        return null;  //will return null if this method is called while there are no targets
    }

    private void firArrow()
    {



     

        GameObject bulletGO = (GameObject)Instantiate(arrow,firepoint.position, firepoint.rotation);
        bulletGO.GetComponent<arrowmovement>().setTarget(targetclosest());
        CurrentAmmo--;



    }



    private void OnTriggerEnter2D(Collider2D collision)
    {


      
      
        targetlist.Add(collision.gameObject);       //when a Gameobject gets in range its added to a list of potential targets
  


    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        targetlist.Remove(collision.gameObject);        //once it leave the radius its taken off the targets list

    }


}
