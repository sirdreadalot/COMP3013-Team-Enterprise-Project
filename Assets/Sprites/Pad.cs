using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pad : MonoBehaviour
{
    // Start is called before the first frame update


    private PadManager pass;
    public GameObject Building;
    public Sprite selected;
    public Sprite unselected;
    public Sprite empty;
    public bool builtUpon = false;

    void Start()
    {

        pass = FindObjectOfType<PadManager>();

        //GetComponent<Image>().enabled = false;

        unselected = GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        //GetComponent<Image>().enabled = true;
    }
    void OnMouseExit()
    {
        //GetComponent<Image>().enabled = false;
    }
    void OnMouseDown()
    {
        GetComponent<Image>().sprite = selected;
        pass.selectedpad(gameObject);
        //GetComponent<Image>().enabled = true;

    }
    public void BuildOn()
    {
        builtUpon = true;
        GetComponent<Image>().sprite = empty;
    }
    public void Deselect()
    {
        GetComponent<Image>().sprite = unselected;
    }
}
