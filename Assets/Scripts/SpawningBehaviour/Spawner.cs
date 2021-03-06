using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Spawner : MonoBehaviour
{
    public int waveNumber = 0;
    public int waveAmplitude = 2;
    public float difficulty = 1.2f;
    public int minBaseEnemies = 10;
    public int startEnemy1 = 5;
    public int startEnemy2 = 10;
    public int startEnemy3 = 15;
    public int bossAmplitude = 3;
    public GameObject noBoss;
    public GameObject bossMonster0;
    public GameObject bossMonster1;
    public GameObject bossMonster2;
    public GameObject bossMonster3;
    public int dontSpawnBoss0Before = 0;
    public int dontSpawnBoss1Before = 0;
    public int dontSpawnBoss2Before = 0;
    public int dontSpawnBoss3Before = 0;
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private GameObject[] mobQueue;
    private int queueCursor;
    private int mobCursor = 0;
    public Vector3 spawnPoint;
    public Quaternion rot;
    public int pauseLength = 10;
    private Animator spawnAnim;
    public GameObject waveUI;
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnAnim = GetComponent<Animator>();
        rot = this.transform.rotation;
        Instantiate(enemy0, spawnPoint, rot);
        //StartCoroutine(SpawningPause());
    }

    public void BeginFirst()
    {
        NextWave();
        spawnAnim.SetBool("isSpawning", true);
    }
    public void SpawnMonster()
    {
        //Debug.Log("Spawning Monster ");
        if(mobCursor < mobQueue.Length)
        {
            Instantiate(mobQueue[mobCursor], spawnPoint, rot);
            mobCursor++;
        } else
        {
            //Debug.Log("Wave " + waveNumber + " Finished.");
            StartCoroutine(SpawningPause());
        }
    }
    //coroutine that pauses between waves and starts the next one
    public IEnumerator SpawningPause()
    {
        Debug.Log("Starting spawning pause...");
        //stops the spawning process
        spawnAnim.SetBool("isSpawning", false);
        //wait for the prescribed pause length
        yield return new WaitForSeconds(pauseLength);
        //Debug.Log("Calculating wave number: " + waveNumber);
        NextWave();
        //retsrats the spawning process
        spawnAnim.SetBool("isSpawning", true);
    }
    public void NextWave()
    {
        mobCursor = 0;
        waveNumber++;

        string waveText = "Wave: " + waveNumber.ToString();
        //Debug.Log(waveText);
        waveUI.GetComponent<Text>().text = waveText;

        //enemy 0

        int e0 = CalculateNumSin(waveNumber);
        //enemy 1
        int e1 = 0;
        if (waveNumber >= startEnemy1)
        {
            e1 = CalculateNumCos(waveNumber - startEnemy1);
        }
        //enemy 2
        int e2 = 0;
        if (waveNumber >= startEnemy2)
        {
            e2 = CalculateNumSin(waveNumber - startEnemy2);
        }
        //enemy 3
        int e3 = 0;
        if (waveNumber >= startEnemy3)
        {
            e3 = CalculateNumCos(waveNumber - startEnemy3);
        }
        //boss enemy
        int eBM = CalculateNumTan(waveNumber);

        //this goes here in case there's no bosses
        GameObject boss = new GameObject();
        if (waveNumber >= dontSpawnBoss0Before)
        {
            try
            {
                boss = ChooseBoss();
            }
            catch
            {
                Debug.Log("Choose Boss doesn't work. Defaulting to first boss.");
                boss = bossMonster0;
            }
        }
        else
        {
            eBM = 0;
            boss = noBoss;
        }

        //total number of mobs for the wave
        int total = e0 + e1 + e2 + e3 + eBM;


        //make the array
        mobQueue = new GameObject[total];
        queueCursor = 0;
        //add the mobs to the array
        AddMobs(e0, enemy0);
        AddMobs(e1, enemy1);
        AddMobs(e2, enemy2);
        AddMobs(e3, enemy3);

        //add the boss monster last so he goes at the end of the wave
        if (boss != null)
        {
            AddMobs(eBM, boss);
        } else
        {
            Debug.Log("Bosses failed to load, randomiser isn't working, defaulting to first boss...");
            boss = bossMonster0;
            AddMobs(eBM, bossMonster0);
        }

        Debug.Log("Starting Wave: " + waveNumber + " | "
            + enemy0.name + ": " + e0 + " | "
            + enemy1.name + ": " + e1 + " | "
            + enemy2.name + ": " + e2 + " | "
            + enemy3.name + ": " + e3 + " | "
            + boss.name + ": " + eBM);

    }
    //Method that adds mobs to the queue
    void AddMobs(int numToAdd,GameObject mobToAdd)
    {
        if (mobToAdd == null)
        {
            mobToAdd = enemy0;
        }
        for (int i = 0; i < numToAdd; i++)
        {
            mobQueue[queueCursor] = mobToAdd;
            queueCursor++;
        }
    }
    //Method that choose and sorts boss monsters
    GameObject ChooseBoss()
    {

        System.Random rand = new System.Random();
        int random = 0;
        GameObject boss = enemy0;
        if (waveNumber >= dontSpawnBoss3Before)
        {
            random = rand.Next(4);
            if (random == 0)
            {
                boss = bossMonster0;
            }
            else if (random == 1)
            {
                boss = bossMonster1;
            }
            else if (random == 2)
            {
                boss = bossMonster2;
            }
            else if (random == 3)
            {
                boss = bossMonster3;
            }
        } else if (waveNumber >= dontSpawnBoss2Before)
        {
            random = rand.Next(3);
            if (random == 0)
            {
                boss = bossMonster0;
            }
            else if (random == 1)
            {
                boss = bossMonster1;
            }
            else if (random == 2)
            {
                boss = bossMonster2;
            }
        } else if (waveNumber >= dontSpawnBoss1Before)
        {
            random = rand.Next(2);
            if (random == 0)
            {
                boss = bossMonster0;
            }
            else if (random == 1)
            {
                boss = bossMonster1;
            }
        } else
        {
            boss = bossMonster0;
        }

        
        Debug.Log("Selected boss: " + boss.name);

        return boss;
        
        //GameObject[] bosses = new GameObject[0];

        ////add the bosses to an array
        //AddBossToArray(bosses, bossMonster0, dontSpawnBoss0Before);
        //AddBossToArray(bosses, bossMonster1, dontSpawnBoss1Before);
        //AddBossToArray(bosses, bossMonster2, dontSpawnBoss2Before);
        //AddBossToArray(bosses, bossMonster3, dontSpawnBoss3Before);
        //AddBossToArray(bosses, bossMonster4, dontSpawnBoss4Before);
        //AddBossToArray(bosses, bossMonster5, dontSpawnBoss5Before);

        //PrintBosses(bosses);

        //System.Random rand = new System.Random();
        //int random = rand.Next(bosses.Length);
        
        //return bosses[random];
    }
    GameObject[] AddBossToArray(GameObject[] array,GameObject boss,int limit)
    {
        GameObject[] newArray = new GameObject[array.Length+1];

        if (boss = null)
        {
            Debug.Log("No boss selected.");
        }
        if (boss != null && limit <= waveNumber)
        {
            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
                Debug.Log("Adding " + array[i].name + " to array.");
            }
            newArray[array.Length] = boss;
            return newArray;
        }
        else
        {
            return array;
        }
    }
    //For Testing
    void PrintBosses(GameObject[] bosses)
    {
        Debug.Log("Attempting to print boss list to console...");
        for (int i = 0; i < bosses.Length; i++)
        {
            Debug.Log("Loaded Boss: " + bosses[i].name);
        }
    }
    //Important Methods for Calculation
    int Amplify(int wn,int wa)
    {
        float amp = wn / wa;
        int x = (int)Mathf.Round(amp);
        return x;
    }
    int MinValue(int min,int num)
    {
        if (num < min)
        {
            return min;
        } else
        {
            return num;
        }
    }
    //Testing methods
    void Test()
    {
        for (int i = 0; i < 11; i++)
        {
            waveNumber = i;
            CalcAll();
        }

    }
    void CalcAll()
    {
        CalculateNumSin(waveNumber);
        CalculateNumCos(waveNumber);
        CalculateNumTan(waveNumber);
    }

    //Calculators
    int CalculateNumSin(int wn)
    {
        int num = 0;
        int x = Amplify(wn,waveAmplitude);

        num = (int)Mathf.Round((Mathf.Sin(x)+2)*(x*difficulty));
        num += minBaseEnemies;
        //Debug.Log("SIN: Calculated from " + waveNumber + " to " + num);

        return MinValue(1, num);
    }
    int CalculateNumCos(int wn)
    {
        int num = 0;
        int x = Amplify(wn, waveAmplitude);

        num = (int)Mathf.Round((Mathf.Cos(x)+2)*(x*difficulty));
        //Debug.Log("COS: Calculated from " + waveNumber + " to " + num);

        return MinValue(0, num);
    }
    int CalculateNumTan(int wn)
    {
        //this one is for big waves of boss monsters
        int num = 0;
        int amp = waveAmplitude*bossAmplitude;

        int x = Amplify(wn, amp);

        num = (int)Mathf.Round(Mathf.Tan(x) + x);
        //Debug.Log("TAN: Calculated from " + waveNumber + " to " + num);

        return MinValue(0,num);
    }
}
