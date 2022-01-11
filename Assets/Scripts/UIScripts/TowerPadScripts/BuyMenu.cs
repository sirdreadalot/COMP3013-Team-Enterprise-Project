using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMenu : MonoBehaviour
{
    public Text towerNameText;
    public GameObject TowerUI;
    UIButtons SelectedTower;
    public GameObject archerTower;


    // Start is called before the first frame update
    void Start()
    {
        SelectedTower = GameObject.FindGameObjectWithTag("ArcherTower").GetComponent<UIButtons>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuySelectedTower()
    {
       


        // Buy the Archer tower
        if (SelectedTower.towerSelected == 1)
        {
            towerNameText = GameObject.Find("TowerNameTxt").GetComponent<Text>();
            towerNameText.text = "Purchase completed!";
            Instantiate(archerTower, new Vector3(-4, 0, 95), Quaternion.identity);
        }


    }

    public void ExitBuyMenu()
    {
        TowerUI.SetActive(false);
    }
    
}
