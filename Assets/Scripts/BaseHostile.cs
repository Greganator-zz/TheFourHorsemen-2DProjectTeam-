using UnityEngine;
using System.Collections;

public class BaseHostile : BaseUnit {


    public Transform player;

    // Update is called once per frame
    void Update () {

        float y = player.transform.position.y - transform.position.y;
        float x = player.transform.position.x - transform.position.x;

        Move(x, y);
    }
}
