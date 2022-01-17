using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private String Tag;

    [SerializeField]  private Transform target;

    public float speed = 10f;


    public void setTarget(Transform TARGET)
    {

        Tag = gameObject.tag;

     


        target = TARGET;

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (target == null)
        {
            Destroy(gameObject);
            
        
            return;
        }


        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed);

        //if (this.transform.position == target.transform.position)
        //{
        //    hitTarget();
        //    Destroy(gameObject);
        //    return;
        //}

        Vector3 dir = target.position - transform.position;

        float disThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= disThisFrame)
        {

            hitTarget();
            Destroy(gameObject);
            return;


        }

        transform.up = target.transform.position - transform.position;

        transform.Translate(dir.normalized * disThisFrame, Space.World);

        

        //Debug.Log(target);




    }

    void hitTarget()
    {

        if (Tag == "FireBall")
        {

            target.GetComponent<healthAndDamage>().FireNest();

        }

        if (Tag == "AcidSplat")
        {

            target.GetComponent<healthAndDamage>().AcidNest();

        }

        if (Tag == "Frost")
        {

            target.GetComponent<healthAndDamage>().IceNest();

        }





    }





}
