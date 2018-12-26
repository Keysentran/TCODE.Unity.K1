using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite3_2D: MonoBehaviour {

	void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5, 0), ForceMode2D.Force);
	}
}
