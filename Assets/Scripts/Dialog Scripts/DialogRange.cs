using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogRange : MonoBehaviour {
    private NPCMoving npcmove;
    private Vector3 playerPos;

    // Use this for initialization
    void Start () {
		npcmove = GetComponentInParent<NPCMoving>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        playerPos = other.transform.position;
        if (other.gameObject.tag == "Player")
        {
            npcmove.canMove = false;
            npcmove.myRigidbody.bodyType = RigidbodyType2D.Kinematic;
            if (playerPos.y > transform.parent.position.y)
            {
                GetComponentInParent<SpriteRenderer>().sortingOrder = 1;
            }
            else
            {
                GetComponentInParent<SpriteRenderer>().sortingOrder = 0;
            }
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
