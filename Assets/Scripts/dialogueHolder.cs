using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialogueHolder : MonoBehaviour {

    public string[] dialogueLines;
    private DialogueManager dMan;
    public string name;
    private bool playerEnter;
    



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
                dMan.dialogLines = dialogueLines;
                dMan.currentLine = 0;
                dMan.showDialogue(name);

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
