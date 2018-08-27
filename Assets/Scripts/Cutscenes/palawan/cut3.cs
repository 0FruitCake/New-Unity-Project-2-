using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cut3 : MonoBehaviour
{

    private DialogueManager dMan;

    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    private bool playerEnter;
    public bool istriggered;
    public CompanionController theCompanion;
    public questMainPalawan qmp;
    public PlayerMovement2 thePlayer;


    // Use this for initialization
    void Start()
    {
        
        dMan = FindObjectOfType<DialogueManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerEnter)
        {
            dMan.textLines = lines;
            dMan.textimage = img;
            dMan.textName = charac;
            dMan.img = img;
            dMan.images = images;

            if (!dMan.dialogActive)
            {
                dMan.showDialogue();
                dMan.currentLine = 0;
                istriggered = true;
                playerEnter = false;
            }



        }


        if (!dMan.dialogActive && istriggered)
        {
            zoneController zCont = GameObject.FindObjectOfType<zoneController>().GetComponent<zoneController>();
            zCont.zone1State(false);
            zCont.battleOn(true);
            theCompanion.canMove = true;
            thePlayer.incutscene = false;
            qmp.questCompleted();
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerEnter = true;


        }
    }


}
