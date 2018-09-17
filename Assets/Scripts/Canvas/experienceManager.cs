using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class experienceManager : MonoBehaviour {

    public DamageManager dm;
    public PlayerHealthManager phm;
    public int currentLevel;
    public int currentExperience;
    public int maxExperience;
    private sfxManager sfxman;
   


	// Use this for initialization
	void Start () {
        currentLevel = 1;
        currentExperience = 0;
        maxExperience = currentLevel * 100;
        sfxman = FindObjectOfType<sfxManager>();
        DontDestroyOnLoad(transform.gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExperience >= maxExperience)
        {
            sfxman.levelUP.Play();
            dm.levelUp();
            phm.playerMaxHealth += 10;
            phm.playerCurrentHealth = phm.playerMaxHealth;
            currentLevel += 1;
            currentExperience = currentExperience - maxExperience;
            maxExperience = currentLevel * 100;
        }
	}
}
