using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerObject : MonoBehaviour {
    public Transform target;
    public Vector3 translation;
    public Vector3 rotation;
    public Vector3 scale;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        target.position = translation;
        target.eulerAngles = rotation;
        target.localScale = scale;
    }
}
