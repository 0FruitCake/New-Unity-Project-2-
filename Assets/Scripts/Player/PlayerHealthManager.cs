using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {


    public int playerMaxHealth;
    public int playerCurrentHealth;
    public bool isactive;
   
    // Use this for initialization
    void Start () {
    	isactive = true;
        playerCurrentHealth = playerMaxHealth;
        
	}
	
	// Update is called once per frame
	void Update () {
		if(playerCurrentHealth <= 0)
        {
        	isactive = false;
            gameObject.SetActive(false);

        }
        if(playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
	}

    public void HurtPlayer(int damage)
    {
        playerCurrentHealth -= damage;
        Debug.Log(playerCurrentHealth);
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
