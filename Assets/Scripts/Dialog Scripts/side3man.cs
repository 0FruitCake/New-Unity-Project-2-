using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class side3man : MonoBehaviour {

    // Use this for initialization
    public DialogueManager dMan;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public string[] lines2;
    public string[] charac2;
    public string[] img2;
    public Sprite[] images;
    private bool istriggered;
    private bool playerEnter;
    public side3Palawan qmp;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerEnter)
        {
            if (qmp.questIndex == 4)
            {
                questInstance1();
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
    private void questInstance2()
    {
        dMan.textLines = lines2;
        dMan.textimage = img2;
        dMan.textName = charac2;
        dMan.images = images;

        if (!dMan.dialogActive)
        {

            dMan.showDialogue();
            dMan.currentLine = 0;
           

        }
    }
}
