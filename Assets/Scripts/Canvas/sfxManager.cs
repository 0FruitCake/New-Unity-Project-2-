﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxManager : MonoBehaviour {

    public AudioSource swordSwing;
    public AudioSource fireCrackle;
    public AudioSource fireExplosion;
    public AudioSource itemPick;
    public AudioSource potionPick;
    public AudioSource levelUP;
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}