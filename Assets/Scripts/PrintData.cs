using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class PrintData : MonoBehaviour
{
    string[] fileContent;
    // Start is called before the first frame update
    void Start()
    {
        string lineThru = "---------------------------------------------------";
        GameObject pm = GameObject.FindWithTag("Player Manager");
        GameObject spawner = GameObject.FindWithTag("Spawner");
        int startingGold = pm.GetComponent<playerManager>().playerCurrency;
        int startingHealth = pm.GetComponent<playerManager>().playerMaxHealth;
        int enemy0Gold = pm.GetComponent<CoinsScript>().enemy0Coins;
        int enemy1Gold = pm.GetComponent<CoinsScript>().enemy1Coins;
        int enemy2Gold = pm.GetComponent<CoinsScript>().enemy2Coins;
        int bossGold = pm.GetComponent<CoinsScript>().enemy3Coins;

        string enemy0name = spawner.GetComponent<Spawner>().enemy0.name;
        string enemy1name = spawner.GetComponent<Spawner>().enemy1.name;
        string enemy2name = spawner.GetComponent<Spawner>().enemy2.name;

        string boss0name = spawner.GetComponent<Spawner>().bossMonster0.name;
        string boss1name = spawner.GetComponent<Spawner>().bossMonster1.name;
        string boss2name = spawner.GetComponent<Spawner>().bossMonster2.name;
        string boss3name = spawner.GetComponent<Spawner>().bossMonster3.name;

        string[] lines = new string[15];
        lines[0] = "Game Settings:";
        lines[1] = lineThru;
        lines[2] = "Starting Currency: " + startingGold.ToString();
        lines[3] = "Starting Health: " + startingHealth.ToString();
        lines[4] = lineThru;
        lines[5] = "Gold Values";
        lines[6] = enemy0name + ": " + enemy0Gold.ToString();
        lines[7] = enemy1name + ": " + enemy1Gold.ToString();
        lines[8] = enemy2name + ": " + enemy2Gold.ToString();
        lines[9] = "Bosses: " + bossGold.ToString();
        lines[10] = lineThru;
        lines[11] = "Boss Names";
        lines[12] = boss0name + ", " + boss1name + ", " + boss2name + ", " + boss3name;
        lines[13] = lineThru;
        lines[14] = "End of File.";
        fileContent = lines;

        try
        {
            WriteFile();
        }
        catch (Exception e)
        {
            Debug.Log("Couldn't Write Game Settings File");
            Debug.Log(e);
        }
    }
    public void WriteFile()
    {
        using(FileStream fs = File.Create(@".\GameSettings.txt"))
        {
            using(StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < fileContent.Length; i++)
                {
                    sw.WriteLine(fileContent[i]);
                }
            }
        }

    }
}

