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
    public Sprite[] images;
    public Image curimage;
    public int currentLine = 0;
    public int charactime;
    public string name2;
    public LoadNewArea lna;
    public string[] textLines;
    public string[] textName;
    public string[] textimage;
    public int i = 0;
    public int lines;
    public dialogueHolder dh;
    public bool isbtn;
    public bool orgbtn;


    public PlayerMovement thePlayer;



    // Use this for initialization
    void Start()
    {
        lna = new LoadNewArea();
     
    }

    // Update is called once per frame
    void Update()
    {

        if (dialogActive && Input.GetKeyDown(KeyCode.Q))
        {
            currentLine++;
         
        }

        if (currentLine < textLines.Length)       //put to dialog
        {
            int pic = int.Parse(textimage[currentLine]);
            dText.text = textName[currentLine] + ": " + textLines[currentLine];
            image.GetComponent<Image>().sprite = images[pic];

        }
        else if (isbtn)
        {
            btn1.SetActive(true);
            btn2.SetActive(true);
        }
        else
        {
            Debug.Log(orgbtn);
            dh.isButton= orgbtn;         
            dh.isReply = false;
            dialogActive = false;
            dBox.SetActive(false);
            currentLine = 0;
        }
    }



    public void showDialogue(string name1)
    {
        
        dialogActive = true;
        dBox.SetActive(true);
        name2 = name1;

    }
}
  