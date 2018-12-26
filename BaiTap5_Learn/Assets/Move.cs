using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D Dynamic;
    [SerializeField]
    private Rigidbody2D Kinematic;

    private void FixedUpdate()
    {
        Dynamic.AddForce(new Vector2(10, 0), ForceMode2D.Force);
        Kinematic.velocity = new Vector2(-10, 0);
    }
}
