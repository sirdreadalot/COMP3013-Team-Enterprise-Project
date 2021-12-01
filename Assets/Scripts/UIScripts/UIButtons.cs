using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{

    public Text towerNameText;
    private int towerSelected;
    public GameObject towerCanvas;

    // Start is called before the first frame update
    void Start()
    {
        towerNameText = GameObject.Find("TowerNameTxt").GetComponent<Text>();
    }

    public void tower1Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 1";
        towerSelected = 1;
    }

    public void tower2Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 2";
        towerSelected = 2;
    }

    public void tower3Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 3";
        towerSelected = 3;
    }

    public void tower4Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 4";
        towerSelected = 4;
    }

    public void tower5Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 5";
        towerSelected = 5;
    }

    public void tower6Btn()
    {
        towerCanvas.SetActive(true);
        towerNameText.text = "Tower 6";
        towerSelected = 6;
    }
}
