using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {

    public int damage;
    public GameObject damageBurst;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void OnTriggerEnter2D(Collider2D other)
    {
        
        {
            if (other.CompareTag("Enemy")) 
            {
                other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damage + Random.Range(0, 2));
                Instantiate(damageBurst, transform.position,transform.rotation);
            }
        }
    }
}
