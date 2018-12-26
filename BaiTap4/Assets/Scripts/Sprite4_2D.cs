using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite4_2D : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {        
        float move = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.Translate(move, 0,0);
    }
}
