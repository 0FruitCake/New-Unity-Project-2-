using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour {
    public float respawntime;
    public float currentrestime;
    public bool respawnon;
    public PlayerHealthManager phm;
    public GameObject player;
    private Vector3 targetPos;
    public float moveSpeed;
    // Use this for initialization
    void Start () {
        respawnon = true;
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);

        if (phm.playerCurrentHealth <= 0)
        {


            if (respawnon)
            {
                if (currentrestime > 0)
                {
                    currentrestime -= Time.deltaTime;
                }

                if (currentrestime <= 0)
                {

                    phm.playerCurrentHealth = phm.playerMaxHealth / 3;
                    player.SetActive(true);

                    currentrestime = respawntime;
                }
            }
            else if (!respawnon)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
