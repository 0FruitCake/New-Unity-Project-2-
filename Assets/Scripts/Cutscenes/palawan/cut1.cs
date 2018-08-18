using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cut1 : MonoBehaviour {

    private DialogueManager dMan;

    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    private bool playerEnter;
    public Transform target;
    private bool dialogOngoing;
    public bool istriggered;
    private CompanionController theCompanion;

    // Use this for initialization
    void Start()
    {
        theCompanion = FindObjectOfType<CompanionController>();
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
            int pic = int.Parse(img[dMan.currentLine]);
            dMan.image.GetComponent<Image>().sprite = images[pic];

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
            theCompanion.incutscene = true;
            theCompanion.target = target;
            theCompanion.canMove = true;
            theCompanion.isWalking = true;

            transform.gameObject.SetActive(false);
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
