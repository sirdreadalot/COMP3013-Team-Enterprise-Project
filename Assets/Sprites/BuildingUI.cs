using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    // Start is called before the first frame update

    private PadManager pass;
    private playerManager currency;
    public Text gold;

    void Start()
    {
        pass = FindObjectOfType<PadManager>();
        currency = FindObjectOfType<playerManager>();
        gold = GameObject.FindGameObjectWithTag("Gold").GetComponent<Text>();
        gold.text = "Gold: " + currency.playerCurrency.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildIceTower()
    {
        if (currency.playerCurrency == 5 || currency.playerCurrency < 5) {
            
            currency.playerCurrency -= 5;
            gold.text = "Gold: " + currency.playerCurrency.ToString();

            pass.TowerToBuild = "IceTower";
            pass.BuildTower();
        }
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
