using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite3_3D : MonoBehaviour {
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector2(-15, 0), ForceMode.Force);
    }
}
