using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogRange : MonoBehaviour {
    private NPCMoving npcmove;

    // Use this for initialization
    void Start () {
		npcmove = GetComponentInParent<NPCMoving>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            npcmove.canMove = false;
            npcmove.myRigidbody.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            npcmove.canMove = true;
            npcmove.myRigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
