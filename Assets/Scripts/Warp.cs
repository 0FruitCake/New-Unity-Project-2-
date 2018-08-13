using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    // Use this for initialization
    public Transform warpTarget;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = warpTarget.position;
        }
        
        
    }
}
