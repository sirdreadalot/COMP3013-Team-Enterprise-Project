using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempgobomovement : MonoBehaviour
{

    private float speed = 2;
    public GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);

        
    }
}
