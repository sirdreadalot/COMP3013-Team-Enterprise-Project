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

    public int goldcount;

    void Start()
    {
        pass = FindObjectOfType<PadManager>();
        currency = FindObjectOfType<playerManager>();
        UpdateGold();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateGold()
    {

       
        gold.text = currency.playerCurrency.ToString();


    }

    public void BuildIceTower()
    {
        if (currency.playerCurrency >= 5) {
            
            currency.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "IceTower";
            pass.BuildTower();
        }
    }

    public void BuildFireTower()
    {
        if (currency.playerCurrency >= 10)
        {

            currency.playerCurrency -= 10;

            UpdateGold();
            pass.TowerToBuild = "FireTower";
            pass.BuildTower();
        }
    }


    public void BuildMageTower()
    {
        if (currency.playerCurrency >= 10)
        {

            currency.playerCurrency -= 10;

            UpdateGold();
            pass.TowerToBuild = "MageTower";
            pass.BuildTower();
        }
    }


    public void BuildAcidTower()
    {
        if (currency.playerCurrency >= 5)
        {

            currency.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "AcidTower";
            pass.BuildTower();
        }
    }


    public void BuildArcherTower()
    {
        if (currency.playerCurrency >= 5)
        {

            currency.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "ArcherTower";
            pass.BuildTower();
        }
    }
}
