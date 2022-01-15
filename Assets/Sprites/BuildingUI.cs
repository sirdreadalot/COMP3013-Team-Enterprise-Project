using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    // Start is called before the first frame update

    private PadManager pass;
    private playerManager playermanager;
    public Text gold;
    public Text Score;

    public int goldcount;

    void Start()
    {
        pass = FindObjectOfType<PadManager>();
        playermanager = FindObjectOfType<playerManager>();
        UpdateGold();
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateGold()
    {

       
        gold.text = playermanager.playerCurrency.ToString();


    }
    public void UpdateScore()
    {


        Score.text = playermanager.playerScore.ToString();
        

    }

    public void BuildIceTower()
    {
        if (playermanager.playerCurrency >= 5) {

            playermanager.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "IceTower";
            pass.BuildTower();
        }
    }

    public void BuildFireTower()
    {
        if (playermanager.playerCurrency >= 10)
        {

            playermanager.playerCurrency -= 10;

            UpdateGold();
            pass.TowerToBuild = "FireTower";
            pass.BuildTower();
        }
    }


    public void BuildMageTower()
    {
        if (playermanager.playerCurrency >= 10)
        {

            playermanager.playerCurrency -= 10;

            UpdateGold();
            pass.TowerToBuild = "MageTower";
            pass.BuildTower();
        }
    }


    public void BuildAcidTower()
    {
        if (playermanager.playerCurrency >= 5)
        {

            playermanager.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "AcidTower";
            pass.BuildTower();
        }
    }


    public void BuildArcherTower()
    {
        if (playermanager.playerCurrency >= 5)
        {

            playermanager.playerCurrency -= 5;

            UpdateGold();
            pass.TowerToBuild = "ArcherTower";
            pass.BuildTower();
        }
    }
}
