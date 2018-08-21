using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionPickUp : MonoBehaviour {

    public PlayerHealthManager phm;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            phm.playerCurrentHealth += 20;
            Destroy(gameObject);
        }
    }
}
