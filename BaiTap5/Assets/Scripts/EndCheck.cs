using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheck : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Clound")
        {
            Destroy(col.gameObject, 1f);
            Debug.Log("Cham may");
        }
    }
}
