using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
    public Transform[] positions;
    public GameObject[] objects;
    public float[] speed;
    private float timer=0;
    private void Start()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(objects[i], positions[i]);
        }
    }
    private void Update()
    {

        positions[0].Translate(Vector3.down * Time.deltaTime*speed[0]);
        positions[1].Translate(Vector3.right * Time.deltaTime * speed[1]);
        positions[2].Translate(Vector3.up * Time.deltaTime * speed[2]);
        positions[3].Translate(Vector3.left * Time.deltaTime * speed[3]);

    }
}
