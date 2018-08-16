using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dBox;
    public GameObject image;
    public GameObject btn1;
    public GameObject btn2;
    public Text dText;
    public Text dtext2;
    public bool dialogActive;
    public string[] dialogLines;
    public Sprite[] images;
    public Image curimage;
    public int currentLine = 0;
    public int charactime;
    public string name2;
    public LoadNewArea lna;
    public TextAsset textFile;
    public TextAsset reply;
    public string[] textLines;
    public string[] textLines2;
    public int i = 0;
    public int lines;
    public int choice;
    public int j;
    public int k;
    public bool choice0;
    public bool choice1;
    public bool replyon;

   
    public PlayerMovement thePlayer;

    

    // Use this for initialization
    void Start()
    {
        lna = new LoadNewArea();
        if (textFile != null)    //file readet
        {
            textLines = (textFile.text.Split('\n', ';'));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Q))
        {
            currentLine++;
            i += 3;


        }
        if (!replyon)
        {


            if (i < textLines.Length - 1)       //put to dialog
            {
                int pic = int.Parse(textLines[i + 2]);
                dText.text = textLines[i] + ": " + textLines[i + 1];
                image.GetComponent<Image>().sprite = images[pic];

            }

            if (currentLine > textLines.Length / 3 - 1)  // pag wla nay lines
            {
                if (textLines.Length % 3 != 0) // button
                {
                    btn1.SetActive(true);
                    btn2.SetActive(true);

                }
                else
                {

                    dialogActive = false;
                    dBox.SetActive(false);
                    currentLine = 0;
                    i = 0;
                }

            }
        }
       

        else
        {

            if (choice0 == true)
            {
                /*if (i < textLines.Length - 1)       //put to dialog
                {
                    int pic = int.Parse(textLines[i + 2]);
                    dText.text = textLines[i] + ": " + textLines[i + 1];
                    image.GetComponent<Image>().sprite = images[pic];

                }

                if (currentLine > textLines.Length / 3 - 1)  // pag wla nay lines
                {
                    if (textLines.Length % 3 != 0) // button
                    {
                        btn1.SetActive(true);
                        btn2.SetActive(true);

                    }
                    else
                    {

                        dialogActive = false;
                        dBox.SetActive(false);
                        currentLine = 0;
                        i = 0;
                    }
                 }

                */
                Debug.Log("in");


                dialogActive = false;
                dBox.SetActive(false);
                i = 0;
                currentLine = 0;
                movePlayer();
                choice0 = false;

            }


            else if (choice1 == true)
            {
               
             
                if (reply != null)    //file readet
                {
                    
                    textLines2 = (reply.text.Split('\n', ';'));
                }
                else
                {
                    dialogActive = false;
                    dBox.SetActive(false);

                }

                if (i < textLines2.Length - 1)       //put to dialog
                {

                    int pic = int.Parse(textLines2[i + 2]);
                    dText.text = textLines2[i] + ": " + textLines2[i + 1];
                    image.GetComponent<Image>().sprite = images[pic];

                }
                
                if (currentLine > textLines2.Length / 3 - 1)  // pag wla nay lines
                {
                    Debug.Log("yaaay"+ (textLines2.Length / 3 - 1));
                    dialogActive = false;
                    dBox.SetActive(false);

                    i = 0;
                    currentLine = 0;
                    replyon = false;
                }
               


               // i = 0;
                //currentLine = 0;
                //choice1 = false;
               
            }
        }

    }

    public void showDialogue(string name1)
    {
        dialogActive = true;
        dBox.SetActive(true);
        name2 = name1;
        
    }

    public void choosebtn() {

        // Debug.Log(name);
        //if (name2 == "Assistant")
        // {
        //  lna.loadFromDialogue(name2);
        //}

        choice0 = true;
        replyon = true;
        btn1.SetActive(false);
        btn2.SetActive(false);

    }
    public void choosebtn1() {
        choice1 = true;
        //choice = 1;
        btn1.SetActive(false);
        btn2.SetActive(false);
        replyon = true;
        i = 0;
        currentLine = 0;
    }

    public void movePlayer()
    {
        thePlayer.cutscene = true;
    }
}
