using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float jumpForce = 1f;

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate() {
        if (GameMain.Phase == (int)GameMain._phase._gameOver)
        {
            rb.simulated = false;
        }
        if (GameMain.Phase == (int)GameMain._phase._play)
        {
            rb.simulated = true;
        }
        if (GroundCheck.groundCheck)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Tree")
        {
            GameMain.Phase = (int)GameMain._phase._gameOver;
        }
    }
}
