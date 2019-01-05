using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloundControl : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 3f;

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-speed, 0);
    }
    private void Update()
    {
        if (GameMain.Phase == (int)GameMain._phase._start)
        {
            Destroy(gameObject);
        }
        if (GameMain.Phase == (int)GameMain._phase._play)
        {
            rb.simulated = true;
        }
        if (GameMain.Phase == (int)GameMain._phase._gameOver)
        {
            rb.simulated = false;
        }
        DestroyToEndPoint();
    }

    private void DestroyToEndPoint()
    {
        float x = transform.position.x;
        if (x <= GameMain.endPoint.x)
        {
            Destroy(gameObject);
        }
    }
}
