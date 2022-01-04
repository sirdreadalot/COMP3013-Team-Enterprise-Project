using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPads : MonoBehaviour
{

    public bool padClickedOn;
    public GameObject TowerPadWarning;
    public GameObject towerUI; // Canvas you want to be hidden on game start
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (padClickedOn == true)
        {
            TowerPadWarning.SetActive(false);
        }
    }

    public void towerPlacement1()
    {
        towerUI.SetActive(true);
        padClickedOn = true;
        //towerButtons.SetActive(true);
    }
}
