using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour {

    protected Rigidbody2D rb;
    protected SpriteRenderer sr;
    protected Animator anim;
    protected float raycastDistance = 0.1f;
    protected float raycastOffset = 0.4f;
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

        if (verticalInput == 0)
        {
            anim.SetBool("BackwardsWalk", false);
            anim.SetBool("ForwardWalk", false);

            if (horizontalInput < 0)
            {
                anim.SetBool("LeftWalk", true);
                anim.SetBool("RightWalk", false);
            }
            if (horizontalInput > 0)
            {
                anim.SetBool("LeftWalk", false);
                anim.SetBool("RightWalk", true);
            }
        }
        if(horizontalInput == 0)
        {
            anim.SetBool("LeftWalk", false);
            anim.SetBool("RightWalk", false);

            if(verticalInput < 0)
            {
                anim.SetBool("BackwardsWalk", false);
                anim.SetBool("ForwardWalk", true);
            }
            if(verticalInput > 0)
            {
                anim.SetBool("BackwardsWalk", true);
                anim.SetBool("ForwardWalk", false);
            }

        }


        
    }
}
