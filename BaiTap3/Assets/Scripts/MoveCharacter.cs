using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
    public Transform[] target;
    public float[] speed;
    private float timer=0;
    private void Update()
    {
        timer += Time.deltaTime;
        target[0].Translate(Vector3.down * Time.deltaTime*speed[0]);
        target[1].Translate(Vector3.right * Time.deltaTime * speed[1]);
        target[2].Translate(Vector3.up * Time.deltaTime * speed[2]);
        target[3].Translate(Vector3.left * Time.deltaTime * speed[3]);

        Debug.Log(timer);
    }
}
