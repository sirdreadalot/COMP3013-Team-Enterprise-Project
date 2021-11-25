using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class archerbehaviour : MonoBehaviour
{
    [SerializeField] private List<GameObject> targetlist = new List<GameObject>();
    
   [SerializeField]  GameObject Target;

    [SerializeField] private float closestEnemy = 0;
    [SerializeField] private float dist = 0;
    




    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {

        if (targetlist.Count() == 0)
        {
            Target = null;
            closestEnemy = 0;
            dist = 0;
        }
        else
        if (targetlist.Count() != 0)
        {

            closestEnemy = Vector2.Distance(this.transform.position, targetlist[0].transform.position);


            for (int i = 0; i < targetlist.Count(); i++)
            {

                dist = Vector2.Distance(this.transform.position, targetlist[i].transform.position);




                if (dist <= closestEnemy)
                {

                    Target = targetlist[i];
                    dist = closestEnemy;

                }


            }


        }

  

    }


    


    private void OnTriggerEnter2D(Collider2D collision)
    {


      
      
        targetlist.Add(collision.gameObject);
  


    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        targetlist.Remove(collision.gameObject);

      




    }





}
