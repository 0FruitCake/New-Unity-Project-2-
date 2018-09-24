using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour {

    // Use this for initialization
    
    private sfxManager sfxMan;
    private DamageManager dm;

    void Start()
    {
        sfxMan = FindObjectOfType<sfxManager>();
    }

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(FindObjectOfType<DamageManager>() == null)
        {

            dm = FindObjectOfType<DamageManager>();
        }

        if (other.gameObject.tag == "Player")
        {
            sfxMan.itemPick.Play();
            dm.levelUp();
            dm.levelUp();
            dm.levelUp();
            transform.gameObject.SetActive(false);
        }
    }
}
