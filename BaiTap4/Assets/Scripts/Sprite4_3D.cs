using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite4_3D : MonoBehaviour {

    public float speed = 1f;
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
    }
}
