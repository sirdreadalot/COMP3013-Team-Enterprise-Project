using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTowers : MonoBehaviour
{
    
    public GameObject pads;
    public GameObject towerButtons;
    public GameObject towerButtonBG;
    public bool padsOn = false;

    // Start is called before the first frame update
    void Start()
    {
        pads.SetActive(false);
        towerButtonBG.SetActive(false);
        towerButtons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void showTowers()
    {
        if(padsOn == true)
        {
            pads.SetActive(false);
            towerButtons.SetActive(false);
            towerButtonBG.SetActive(false);
            padsOn = false;
        }

        else
        {
            pads.SetActive(true);
            towerButtonBG.SetActive(true);
            towerButtons.SetActive(true);
            padsOn = true;
        }
    }
}
