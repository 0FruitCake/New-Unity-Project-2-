﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mango : MonoBehaviour {

    // Use this for initialization
    public side1Palawan s1p;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            s1p.mangoCount += 1;
            transform.gameObject.SetActive(false);
        }
    }
}