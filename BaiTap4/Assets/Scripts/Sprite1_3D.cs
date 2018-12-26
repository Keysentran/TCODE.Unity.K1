using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite1_3D : MonoBehaviour {

    public float jumpForce = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().velocity = Vector2.up * jumpForce;
        }
    }
}
