using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour {

    public string[] dialogueLines;
    private DialogueManager dMan;
    private string name;



	// Use this for initialization
	void Start () {
        name = gameObject.name;
        dMan = FindObjectOfType<DialogueManager>();  
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                if (!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.showDialogue();

                    if(name == "Assistant")
                    {
                        if (!dMan.dialogActive)
                        {

                        }
                    }
                }
            }
        }
    }
}
