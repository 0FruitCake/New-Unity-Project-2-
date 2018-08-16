using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialogueHolder : MonoBehaviour {
    
    private DialogueManager dMan;
    public string name;
    private bool playerEnter;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public string[] Replines;
    public string[] Repcharac;
    public string[] Repimg;
    public bool isButton;
    public bool isReply;

  
    



	// Use this for initialization
	void Start () {
        
        dMan = FindObjectOfType<DialogueManager>();
        dMan.orgbtn = isButton;

    }
	
	// Update is called once per frame
	void Update () {
        dMan.isbtn = isButton;
      
        if (!isReply)
        {
            dMan.textLines = lines;
            dMan.textimage = img;
            dMan.textName = charac;
            if (Input.GetKeyDown(KeyCode.F) && playerEnter)
            {
                name = gameObject.transform.parent.name;
                Debug.Log(name);
                if (!dMan.dialogActive)
                {

                    dMan.showDialogue(name);
                    dMan.currentLine = 0;



                }
            }
        }
        else if (isReply) {
           
            dMan.textLines = Replines;
            dMan.textimage = Repimg;
            dMan.textName = Repcharac;
            if (Input.GetKeyDown(KeyCode.F) && playerEnter)
            {
                name = gameObject.transform.parent.name;
                Debug.Log(name);
                if (!dMan.dialogActive)
                {

                    dMan.showDialogue(name);
                    dMan.currentLine = 0;



                }
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
    public void choosebtn() {


     }
    public void choosebtn2()
    {
        isButton = false;
        isReply = true;
        dMan.currentLine = 0;
        dMan.btn1.SetActive(false);
        dMan.btn2.SetActive(false);
    }
}
