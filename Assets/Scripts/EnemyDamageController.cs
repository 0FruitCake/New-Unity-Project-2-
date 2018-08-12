using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageController : MonoBehaviour {


    public int damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.CompareTag("Player"))
            {
                other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damage+Random.Range(0,2));
            }
        }
    }
}
