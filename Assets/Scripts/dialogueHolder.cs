using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialogueHolder : MonoBehaviour {
    
    private DialogueManager dMan;
    public string name;

    private bool playerEnter;
    public TextAsset text;
    public TextAsset reply;
    



	// Use this for initialization
	void Start () {
        
        dMan = FindObjectOfType<DialogueManager>();  

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F) && playerEnter)
        {

            name = gameObject.transform.parent.name;
            Debug.Log(name);
            if (!dMan.dialogActive)
            {
                dMan.currentLine = 0;
                dMan.showDialogue(name);
                dMan.btn1.SetActive(false);
                dMan.btn2.SetActive(false);
                dMan.textFile = text;
                dMan.reply = reply;

            }
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            playerEnter = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            playerEnter = false;
        }
    }
}
