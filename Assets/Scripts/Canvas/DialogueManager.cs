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

    public int currentLine;
    public string[] textLines;
    public string[] textName;
    public string[] textimage;
    public bool buttonActive;
    public bool isreply;

    public PlayerMovement thePlayer;



    // Use this for initialization
    void Start()
    {
    
     
    }

    // Update is called once per frame
    void Update()
    {

        if (dialogActive && Input.GetKeyDown(KeyCode.Q) && !buttonActive)
        {
            currentLine++;
         
        }
        if(currentLine >= textLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;

            if (isreply)
            {
                isreply = false;
            }
        }

        if (dialogActive)
        {

            int pic = int.Parse(textimage[currentLine]);
            dText.text = textName[currentLine] + ": " + textLines[currentLine];
            

        }

      
    }


    public void showDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }
    
}
  