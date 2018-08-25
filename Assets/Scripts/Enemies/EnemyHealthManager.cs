using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyMaxHealth;
    public int enemyCurrentHealth;
    public GameObject potion;
    public bool isDead;
    public experienceManager expm;
    public int expGiven;
    public bool isQuestMonster;
    public bool isQuestActive;
    private questMainPalawan qmp;
    public int dropchance;

    // Use this for initialization
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            if(isQuestActive && isQuestMonster)
            {
                qmp = FindObjectOfType<questMainPalawan>();
                qmp.wolfcount += 1;
            }
            int x = Random.Range(0, dropchance);
            Debug.Log(x);
            if(x == 1) {
                var clone = (GameObject)Instantiate(potion, transform.position, transform.rotation);
                clone.SetActive(true);
            }
            expm.currentExperience += expGiven;
            Debug.Log(expm.currentExperience);
            gameObject.SetActive(false);
            isDead = true;
            
        }
    }

    public void HurtEnemy(int damage)
    {
        enemyCurrentHealth -= damage;
        
    }

    public void SetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

  

   
}
