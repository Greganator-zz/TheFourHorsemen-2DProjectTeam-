using UnityEngine;
using System.Collections;

public class CharaterLight : BaseColour {

    private Vector2 velocity = Vector2.zero;
    private float minLight = 1;
    private float maxLight = 16.4f;
    private float tParam = 0;




    // Update is called once per frame
    void Update()
    {
        GreyScale(offsetY);


       darknessplane.GetComponent<Renderer>().material.SetFloat("_PColourMaxRadius", 0);
           
        }

    }