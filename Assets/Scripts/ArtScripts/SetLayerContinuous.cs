using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerContinuous : MonoBehaviour
{

    private float yValue;
    private SpriteRenderer rend;
    private int sortTo;

    // Update is called once per frame
    void Update()
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
