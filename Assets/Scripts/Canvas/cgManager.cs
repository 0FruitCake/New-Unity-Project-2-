using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgManager : MonoBehaviour
{
    public GameObject cgBox;
    public GameObject CG;
    public GameObject cgDbox;
    public Text dText;
    public bool cgActive;
    public Sprite[] images;
    public string[] img;
    public int currentLine;
    public string[] textLines;
    public string[] textName;
    public string[] textimage;
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cgActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;

        }
        if (currentLine >= textLines.Length)
        {
            cgBox.SetActive(false);
            cgActive = false;
            currentLine = 0;


        }

        if (cgActive)
        {

            int pic = int.Parse(textimage[currentLine]);
            CG.GetComponent<Image>().sprite = images[pic];
            if(textName[currentLine] != "")
            {
                dText.text = textName[currentLine] + ": " + textLines[currentLine];
            }
            else
            {
                dText.text = textLines[currentLine];
            }

        }


    }


    public void showDialogue()
    {
        cgActive = true;
        cgBox.SetActive(true);
    }
}


