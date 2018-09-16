using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class companionDialogue : MonoBehaviour
{

    // Use this for initialization
    public DialogueManager dMan;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    private bool istriggered;
    private bool playerEnter;
    public questMainPalawan qmp;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public Text btntext;
    public Text btntext2;
    public Text btntext3;
    public string btext;
    public string btext2;
    public string btext3;

    public cgManager cgman;
   
    public string[] cglines;

    public string[] cgimg;
    public Sprite[] cgimages;
    private LoadNewArea lna;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerEnter)
        {
            if (qmp.questIndex >8)
            {
                questInstance1();
                if(qmp.questIndex == 9)
                {
                    qmp.questCompleted();
                }
                
            }


        }

        if (dMan.currentLine == 7 && playerEnter)
        {

            dMan.buttonActive = true;
            btntext.text = btext;
            btntext2.text = btext2;
            btntext3.text = btext3;
            btn1.SetActive(true);
            btn2.SetActive(true);
            btn3.SetActive(true);
        }
        if (!dMan.dialogActive && istriggered)
        {
            
            istriggered = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEnter = true;



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

    public void choosebtn()
    {

        Debug.Log("button1selected");
        dMan.buttonActive = false;
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        dMan.currentLine++;
        runCG();


    }
    public void choosebtn2()
    {


        dMan.buttonActive = false;
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        dMan.currentLine++;

    }


    public void choosebtn3()
    {


        dMan.buttonActive = false;
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        dMan.currentLine++;
        
    }

    public void runCG()
    {
        Debug.Log("CGGGG");
        cgman.textLines = cglines;
        cgman.textimage = cgimg;
        cgman.images = cgimages;


        if (!cgman.cgActive)
        {
            cgman.currentLine = 0;
            cgman.showDialogue();
            istriggered = true;

        }


        //if (cgman.currentLine == 13)
        //{

           // lna.loadFromDialogue("palawan");
            //istriggered = false;
           // playerEnter = false;

        //}

    }
    

        
}

