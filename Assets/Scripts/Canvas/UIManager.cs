using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    
    public Text hpText;
    public PlayerHealthManager playerHealth;
    public Slider healthBar;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        hpText.text = playerHealth.playerCurrentHealth + " / " + playerHealth.playerMaxHealth;
	}
}
