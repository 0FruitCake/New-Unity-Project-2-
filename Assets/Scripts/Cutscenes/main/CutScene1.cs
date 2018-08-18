using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene1 : MonoBehaviour {

    public GameObject player;
    private PlayerMovement pm;

    // Use this for initialization
    void Start()
    {
        pm = player.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.gameObject.tag == "Player" & pm.cutscene == true)
        {
            
            pm.cutscene = false;
            pm.anim.SetFloat("LastMoveY", pm.lastMove.y);
        }
    }
}
