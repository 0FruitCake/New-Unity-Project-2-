using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    
    public Text hpText;
    public PlayerHealthManager playerHealth;
    public Slider healthBar;
    public experienceManager experience;
    public Slider experienceBar;
    public Text experienceText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        hpText.text = playerHealth.playerCurrentHealth + " / " + playerHealth.playerMaxHealth;
        experienceBar.maxValue = experience.maxExperience;
        experienceBar.value = experience.currentExperience;
        experienceText.text = "Lv." + experience.currentLevel + " (" + experience.currentExperience + "/" + experience.maxExperience + ")";
	}
}
