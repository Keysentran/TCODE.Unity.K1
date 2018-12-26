using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite2_2D : MonoBehaviour {

	void Update () {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
    }
}
