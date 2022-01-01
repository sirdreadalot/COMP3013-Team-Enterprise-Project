using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    public Sprite tower1Image;
    public Text towerNameText;
    public int towerSelected;
    public GameObject clickAtowerWarning;
    public GameObject towerUI;

    // Start is called before the first frame update
    void Start()
    {
        towerNameText = GameObject.Find("TowerNameTxt").GetComponent<Text>();
        tower1Image = GameObject.Find("towerUI").GetComponent<Sprite>();
    }

    void Update()
    {
        
    }

    public void tower1Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Archer";
        towerSelected = 1;
        //GameObject.Find("towerUI").GetComponent<Sprite>() = tower1Image; // Find out how to change source image on a gameObject
    }

    public void tower2Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Tower 2";
        towerSelected = 2;
    }

    public void tower3Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Tower 3";
        towerSelected = 3;
    }

    public void tower4Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Tower 4";
        towerSelected = 4;
    }

    public void tower5Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Tower 5";
        towerSelected = 5;
    }

    public void tower6Btn()
    {
        towerUI.SetActive(true);
        clickAtowerWarning.SetActive(false);
        towerNameText.text = "Tower 6";
        towerSelected = 6;
    }

}
