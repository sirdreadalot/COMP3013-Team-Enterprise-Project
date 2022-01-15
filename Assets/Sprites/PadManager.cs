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
    private playerManager playermanager;



    void Start()
    {

        playermanager = FindObjectOfType<playerManager>();
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
                Vector3 spawnlocation = new Vector3(padlocation.x, padlocation.y, 0);


                if (TowerToBuild == "IceTower")
                {

                    GameObject tower = (GameObject)Instantiate(IceTower, spawnlocation, Quaternion.identity);
                    SelectedPad.GetComponent<Pad>().Building = tower;
                    playermanager.playerCurrency -= 5;

            }
                if (TowerToBuild == "FireTower")
                {

                    GameObject tower = Instantiate(FireTower, spawnlocation, Quaternion.identity);
                    SelectedPad.GetComponent<Pad>().Building = tower;
                     playermanager.playerCurrency -= 10;


            }
                if (TowerToBuild == "MageTower")
                {

                    GameObject tower = Instantiate(MageTower, spawnlocation, Quaternion.identity);
                    SelectedPad.GetComponent<Pad>().Building = tower;
                     playermanager.playerCurrency -= 10;


            }
                if (TowerToBuild == "AcidTower")
                {

                    GameObject tower = Instantiate(AcidTower, spawnlocation, Quaternion.identity);
                    SelectedPad.GetComponent<Pad>().Building = tower;
                    playermanager.playerCurrency -= 5;

            }
                if (TowerToBuild == "ArcherTower")
                {

                    GameObject tower = Instantiate(ArcherTower, spawnlocation, Quaternion.identity);
                    SelectedPad.GetComponent<Pad>().Building = tower;
                    playermanager.playerCurrency -= 5;

            }


                SelectedPad.GetComponent<Pad>().builtUpon = true;


            }

        




    }





}
