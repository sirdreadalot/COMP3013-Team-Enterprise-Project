using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linecontroller : MonoBehaviour
{


    [SerializeField] LineRenderer LineRenderer;

    [SerializeField] private Texture[] textures;

    private int animationsteps;

    private float fps = 30f;
    private float fpscounter;



    // Start is called before the first frame update
    void Start()
    {
        LineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        fpscounter += Time.deltaTime;

        if (fpscounter >= 1f / fps)
        {
            animationsteps++;

            if (animationsteps == textures.Length)
            {
                animationsteps = 0;
            }


            LineRenderer.material.SetTexture("_MainTex", textures[animationsteps]);

            fpscounter = 0f;
        }



    }
}
