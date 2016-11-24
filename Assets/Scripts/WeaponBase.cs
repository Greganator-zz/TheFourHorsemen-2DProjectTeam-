using UnityEngine;
using System.Collections;

public class WeaponBase: MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        print("hit");
    }
}
