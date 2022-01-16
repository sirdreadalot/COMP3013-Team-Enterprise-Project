using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{

    private playerManager script;
    public Text score;
    private int tempScore;

    // Start is called before the first frame update
    void Start()
    {
        tempScore = playerManager.playerScore;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = tempScore.ToString();
    }
}
