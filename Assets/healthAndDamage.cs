using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthAndDamage : MonoBehaviour
{
    // Start is
    // called before the first frame update

    [SerializeField]
    private int Health = 100;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //Check to see if the tag on the collider is equal to Arrow
        if (other.tag == "Arrow")
        {


            Health -= 50;
            Debug.Log("Triggered by Enemy");



        }
    }


}
