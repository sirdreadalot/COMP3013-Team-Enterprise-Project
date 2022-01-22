using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{

    public int enemy0Coins = 5;
    public int enemy1Coins = 10;
    public int enemy2Coins = 15;
    public int enemy3Coins = 20;

    public int getCoins0()
    {
        return enemy0Coins;
    }
    public int getCoins1()
    {
        return enemy1Coins;
    }
    public int getCoins2()
    {
        return enemy2Coins;
    }
    public int getCoins3()
    {
        return enemy3Coins;
    }
}

