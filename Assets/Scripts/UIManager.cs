using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {

    public static bool UIExists;
    public Slider healthBar;
    public Text hpText;
    public PlayerHealthManager playerHealth;
    private bool inmain;
    

	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().name == "main")
        {
            inmain = true;
        }
        else
        {
            inmain = false;
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (!inmain)
        {

 
            healthBar.maxValue = playerHealth.playerMaxHealth;
            healthBar.value = playerHealth.playerCurrentHealth;
            hpText.text = playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        }

	}
}
