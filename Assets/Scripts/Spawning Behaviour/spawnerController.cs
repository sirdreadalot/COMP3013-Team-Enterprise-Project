using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class spawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] currentWave;
    //temp
    

    public void LoadWaves(string filename)
    {
        //temporary fucky version before I make the filereader
       
    }
    public GameObject[] SendWave()
    {
        

        return currentWave;
    }
}
