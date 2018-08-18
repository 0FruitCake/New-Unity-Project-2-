using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueHolder : MonoBehaviour {
    
    private DialogueManager dMan;

    private bool playerEnter;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public string[] Replines;
    public string[] Repcharac;
    public string[] Repimg;
    public bool isButton;
    public bool isReply;
    public GameObject btn1;
    public GameObject btn2;
    public Text btntext;
    public Text btntext2;
    public string btext;
    public string btext2;
    public Sprite[] images;



    // Use this for initialization
    void Start () {
        
        dMan = FindObjectOfType<DialogueManager>();
        

    }
	
	// Update is called once per frame
	void Update () {

        if (!dMan.isreply)
        {
            dMan.textLines = lines;
            dMan.textimage = img;
            dMan.textName = charac;
            int pic = int.Parse(dMan.textimage[dMan.currentLine]);
            dMan.image.GetComponent<Image>().sprite = images[pic];

            if (dMan.currentLine == 1)
            {
                dMan.buttonActive = true;
                btntext.text = btext;
                btntext2.text = btext2;
                btn1.SetActive(true);
                btn2.SetActive(true);
            }

            
            if (Input.GetKeyDown(KeyCode.F) && playerEnter)
            {
               
                if (!dMan.dialogActive)
                {

                    dMan.showDialogue();
                    dMan.currentLine = 0;


                }
            }
        }
        else if (dMan.isreply) {
           
            dMan.textLines = Replines;
            dMan.textimage = Repimg;
            dMan.textName = Repcharac;
            if (Input.GetKeyDown(KeyCode.F) && playerEnter)
            {
              
                if (!dMan.dialogActive)
                {

                    dMan.showDialogue();
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
        dMan.buttonActive = false;
        
        dMan.isreply = true;
        dMan.currentLine = 0;
        btn1.SetActive(false);
        btn2.SetActive(false);

    }
}
