using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private String Tag;

    private Transform target;

    public float speed = 10;


    public void setTarget(Transform TARGET)
    {

        Tag = gameObject.tag;

     


        target = TARGET;

    }


    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
    
        Vector3 dir = target.position - transform.position;

        float disThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= disThisFrame)
        {

            hitTarget();
            Destroy(gameObject);
            return;


        }

        transform.Translate(dir.normalized * disThisFrame, Space.World);


        //Debug.Log(target);

       
     
        
    }

    void hitTarget()
    {

        if (Tag == "FireBall")
        {

            target.GetComponent<healthAndDamage>().FireNest();

        }


    }





}
