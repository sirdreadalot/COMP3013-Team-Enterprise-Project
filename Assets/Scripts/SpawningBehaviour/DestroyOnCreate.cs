using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCreate : MonoBehaviour
{
    //This script is for things which shouldn't exist

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
