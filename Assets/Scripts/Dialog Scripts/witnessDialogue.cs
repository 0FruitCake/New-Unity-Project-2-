using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witnessDialogue : MonoBehaviour {

	// Use this for initialization
	 public DialogueManager dMan;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    public string[] lines2;
    public string[] charac2;
    public string[] img2;
   
    private bool istriggered;
    private bool playerEnter;
    public side2Palawan qmp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && playerEnter)
        {
            if (gameObject.transform.parent.name == "witness1")
            {
                if (qmp.questIndex == 1)
                {
                    questInstance1();
                }
            }
            else if (gameObject.transform.parent.name == "suspect")
            {
                if (qmp.questIndex == 2)
                {
                    questInstance1();
                }
            }


        }
        if (!dMan.dialogActive && istriggered)
        {
            qmp.questCompleted();
            istriggered = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEnter = true;
            Debug.Log("Hello");


        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEnter = false;

        }
    }

    private void questInstance1()
    {
        dMan.textLines = lines;
        dMan.textimage = img;
        dMan.textName = charac;
        dMan.images = images;

        if (!dMan.dialogActive)
        {

            dMan.showDialogue();
            dMan.currentLine = 0;
            istriggered = true;

        }
    }
}
