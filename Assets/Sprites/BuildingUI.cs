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
        if (playermanager.playerCurrency >= 5) 
        {

            pass.TowerToBuild = "IceTower";
            pass.BuildTower();

            UpdateGold();
   
        }
    }

    public void BuildFireTower()
    {
        if (playermanager.playerCurrency >= 10)
        {
            pass.TowerToBuild = "FireTower";
            pass.BuildTower();


            UpdateGold();
    
        }
    }


    public void BuildMageTower()
    {
        if (playermanager.playerCurrency >= 10)
        {

            pass.TowerToBuild = "MageTower";
            pass.BuildTower();

            UpdateGold();
    
        }
    }


    public void BuildAcidTower()
    {
        if (playermanager.playerCurrency >= 5)
        {



            pass.TowerToBuild = "AcidTower";
            pass.BuildTower();

            UpdateGold();
   
        }
    }


    public void BuildArcherTower()
    {
        if (playermanager.playerCurrency >= 5)
        {

            pass.TowerToBuild = "ArcherTower";
            pass.BuildTower();

            UpdateGold();
          
        }
    }
}
