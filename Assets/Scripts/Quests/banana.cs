using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour {

    public questMainPalawan qmp;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag== "Player")
        {
            qmp.bananaCount += 1;
            transform.gameObject.SetActive(false);
        }
    }
}
