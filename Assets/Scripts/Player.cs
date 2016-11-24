using UnityEngine;
using System.Collections;

public class Player : BaseUnit {

    public float playerSpeed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        //this meathod returns a float that is -1 when i press left and 0 when i press nothing and 1 when i press right
        //get axis has a smoothing  value where as raw returs the value without smothing 
        //Player to move left, right, up, down
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;


        Move(horizontalInput, verticalInput);

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");
        }

    }
}
