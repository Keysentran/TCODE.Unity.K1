﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {
    public float speed = 0.5f;

    private MeshRenderer render;

    private Vector2 offsetDefaul;
	// Use this for initialization
	void Start () {
        render = GetComponent<MeshRenderer>();
        offsetDefaul = render.sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
        if (GameMain.Phase == (int)GameMain._phase._play)
        {
            float x = Mathf.Repeat(Time.time * speed, 1);
            Vector2 newOffset = new Vector2(x, offsetDefaul.y);
            render.sharedMaterial.SetTextureOffset("_MainTex", newOffset);
        }
	}
}
