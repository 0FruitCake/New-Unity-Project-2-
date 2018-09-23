using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        currentrestime = respawntime;
        

    }
	
	// Update is called once per frame
	void Update () {
        if(phm == null && player == null) { 
        phm = FindObjectOfType<PlayerHealthManager>();
        player = GameObject.FindWithTag("Player");
        }

        targetPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);

        if (!phm.isactive)
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
                    phm.isactive = true;

                    currentrestime = respawntime;
                }
            }
            else if (!respawnon)
            {
                restartCurrentScene();
            }
        }
    }
    public void restartCurrentScene()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        phm.playerCurrentHealth = phm.playerMaxHealth;
        player.SetActive(true);
        phm.isactive = true;

    }
}
