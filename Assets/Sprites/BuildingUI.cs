using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingUI : MonoBehaviour
{
    // Start is called before the first frame update

    private PadManager pass;




    void Start()
    {

        pass = FindObjectOfType<PadManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildIceTower()
    {
        pass.TowerToBuild = "IceTower";
        pass.BuildTower();
    }

    public void BuildFireTower()
    {
        pass.TowerToBuild = "FireTower";
        pass.BuildTower();
    }


    public void BuildMageTower()
    {
        pass.TowerToBuild = "MageTower";
        pass.BuildTower();
    }


    public void BuildAcidTower()
    {
        pass.TowerToBuild = "AcidTower";
        pass.BuildTower();
    }


    public void BuildArcherTower()
    {
        pass.TowerToBuild = "ArcherTower";
        pass.BuildTower(); 
    }
}
