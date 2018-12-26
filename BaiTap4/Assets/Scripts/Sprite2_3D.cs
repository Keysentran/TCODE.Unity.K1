using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite2_3D : MonoBehaviour {

    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector2(2, 0);
    }
}
