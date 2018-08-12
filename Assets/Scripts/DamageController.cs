using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {

    public int damage;
    public GameObject damageBurst;
    public GameObject damageNumber;
    public int basedamage;
    public Transform hitPoint;
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
                damage = basedamage + (Random.Range(0, 3));
                
                other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damage);
                var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
                clone.GetComponent<DamageNumbers>().damageNumber = damage;
                Instantiate(damageBurst, transform.position,transform.rotation);
                
            }
        }
    }
}
