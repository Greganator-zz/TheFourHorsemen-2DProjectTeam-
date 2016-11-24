using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour {

    protected Rigidbody2D rb;
    protected SpriteRenderer sr;
    protected Animator anim;
    protected float raycastDistance = 0.1f;
    protected float raycastOffset = 0.4f;
    public Transform greayscalePlane;
    public float speed;


    // Use this for initialization
    void Start()
    {
        //assign rb variable once it points towards the Riged body owner
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    protected void Move(float horizontalInput, float verticalInput)
    {
        //set the velocity to a vertor and then applys the velocity and then apply the actual velocity to the rb
        Vector2 vel = rb.velocity;
        vel.x = horizontalInput * speed;
        vel.y = verticalInput * speed;
        rb.velocity = vel;

        if (horizontalInput < 0)
        {
            sr.flipX = true;
        }
        if (horizontalInput > 0)
        {
            sr.flipX = false;
        }

        //set the animator input of speed to the velocity input of inout
        //animator will handle transition from idel to run
        //send the absolute vvalue of input so when we run left it still plays the animation
        //anim.SetFloat("SpeedHorizontal", Mathf.Abs(horizontalInput));
        //  anim.SetFloat("SpeedVertical", Mathf.Abs(verticalInput));
    }
}
