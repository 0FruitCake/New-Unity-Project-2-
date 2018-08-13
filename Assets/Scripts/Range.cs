using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour {

    private WolfController parent;

	// Use this for initialization
	void Start () {
        parent = GetComponentInParent<WolfController>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player_2")
        {
            parent.myRigidbody.velocity = Vector2.zero;
            parent.Target = other.transform;
            parent.chaseactive = true;
            parent.initial = parent.transform.position;
            
            
        }
    }

    // Update is called once per frame
    
}
