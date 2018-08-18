using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackRangeTrigger : MonoBehaviour {

    
    private WolfController parent;
    // Use this for initialization
    void Start () {

        parent = GetComponentInParent<WolfController>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay2D(Collider2D other)
    {

        {
            if (other.CompareTag("Player"))
            {
                
                parent.isattacking = true;
                parent.attackInstance = 1;
                
            }
        }
    }

   


}
