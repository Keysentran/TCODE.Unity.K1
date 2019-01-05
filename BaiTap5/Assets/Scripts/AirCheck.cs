using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCheck : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GroundCheck.groundCheck = false;
        }
    }

}
