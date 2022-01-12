using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadManager : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private GameObject SelectedPad;

    private Vector2 padlocation;

    [SerializeField] public string TowerToBuild;


    public GameObject IceTower;
    public GameObject FireTower;
    public GameObject MageTower;
    public GameObject AcidTower;
    public GameObject ArcherTower;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public GameObject selectedpad(GameObject pad)
    {

        SelectedPad = pad;


        return SelectedPad;
    }


    


    public void BuildTower()
    {
        

        padlocation = SelectedPad.transform.position;

        if (TowerToBuild == "IceTower")
        {

            GameObject newtower = (GameObject)Instantiate(IceTower);
            newtower.transform.position = padlocation;
            
        }



    }





}
