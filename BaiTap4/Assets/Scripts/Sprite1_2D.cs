using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite1_2D : MonoBehaviour {
    public float jumpForce = 5f;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        }
    }
}
