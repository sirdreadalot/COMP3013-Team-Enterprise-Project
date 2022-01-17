using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseColour : MonoBehaviour
{
    public int amount = 100;
    private SpriteRenderer rend;
    System.Random rand;

    // Start is called before the first frame update
    void Start()
    {
        GameObject randomiser = GameObject.FindWithTag("Player Manager");
        rand = randomiser.GetComponent<Randomiser>().rand;
        rend = this.GetComponent<SpriteRenderer>();

        //Debug.Log("R:" + rend.color.r);

        if (amount > 255 || amount < 0)
        {
            Debug.Log("Make the amount smaller for " + this.name + ", it should be between 0 and 255 and it's currently " + amount + ".");
        } else
        {
            rend.color = MakeColor();
        }

    }
    Color MakeColor()
    {
        Color newColor = new Color(ShiftColour(), ShiftColour(), ShiftColour(), 1);
        //Debug.Log("Color: " + newColor);
        return newColor;
    }
    float ShiftColour()
    {
        float colour = 1.0f;
        float variance = -1*rand.Next(0, amount);
        colour += variance/255;

        return colour;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
