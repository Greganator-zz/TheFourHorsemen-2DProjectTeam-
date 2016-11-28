using UnityEngine;
using System.Collections;

public class CharaterLight : BaseColour {

    private Vector2 velocity = Vector2.zero;
    private float minLight = 1;
    private float maxLight = 1;
    private float tParam = 0;




    // Update is called once per frame
    void Update()
    {
        GreyScale(offsetY);
           
    }

    }