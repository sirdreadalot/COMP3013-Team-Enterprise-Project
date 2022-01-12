using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadManager : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private GameObject SelectedPad;

    private Vector3 padlocation;

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

        

        if (SelectedPad.GetComponent<Pad>().builtUpon == false)
        {



            padlocation = SelectedPad.transform.position;

            if (TowerToBuild == "IceTower")
            {

                GameObject newtower = (GameObject)Instantiate(IceTower);
                newtower.transform.position = padlocation;

            }
            if (TowerToBuild == "FireTower")
            {

                GameObject newtower = (GameObject)Instantiate(FireTower, padlocation, Quaternion.identity);
                newtower.transform.position = padlocation;

            }
            if (TowerToBuild == "MageTower")
            {

                GameObject newtower = (GameObject)Instantiate(MageTower);
                newtower.transform.position = padlocation;

            }
            if (TowerToBuild == "AcidTower")
            {

                GameObject newtower = (GameObject)Instantiate(AcidTower);
                newtower.transform.position = padlocation;

            }
            if (TowerToBuild == "ArcherTower")
            {

                GameObject newtower = (GameObject)Instantiate(ArcherTower);
                newtower.transform.position = padlocation;

            }

            SelectedPad.GetComponent<Pad>().builtUpon = true;

        }






    }





}
