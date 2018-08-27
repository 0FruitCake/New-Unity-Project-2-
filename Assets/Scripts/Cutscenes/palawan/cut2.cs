using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cut2 : MonoBehaviour {

    public PlayerMovement2 pm2;
    public CompanionController cmc;
    public Transform target;
    private bool playerEnter;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerEnter = true;
            pm2.incutscene = true;
            cmc.hasWalkZone = false;
            cmc.myRigidbody.velocity = Vector2.zero;
            cmc.target = target;
            cmc.incutscene = true;

        }
    }
}
