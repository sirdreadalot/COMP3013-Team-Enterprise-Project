using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pad : MonoBehaviour
{
    // Start is called before the first frame update


    private PadManager pass;


    public bool builtUpon = false;

    void Start()
    {

        pass = FindObjectOfType<PadManager>();

        GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        GetComponent<Image>().enabled = true;
    }
    void OnMouseExit()
    {
        GetComponent<Image>().enabled = false;
    }
    void OnMouseDown()
    {

        pass.selectedpad(gameObject);
        GetComponent<Image>().enabled = true;

    }
}
