using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerOnStart : MonoBehaviour
{

    private float yValue;
    private SpriteRenderer rend;
    private int sortTo;

    // Start is called before the first frame update
    void Start()
    {
        SetSortingLayer();
    }
    void SetSortingLayer()
    {
        yValue = this.transform.position.y * -1;
        rend = this.GetComponent<SpriteRenderer>();

        sortTo = (int)Mathf.Round(yValue * 10);
        sortTo += 10;

        rend.sortingOrder = sortTo;
    }
}
