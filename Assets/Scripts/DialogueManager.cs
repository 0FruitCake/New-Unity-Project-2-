using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public GameObject image;
    public Text dText;
    public bool dialogActive;
    public string[] dialogLines;
    public Sprite[] images;
    public Image curimage;
    public int currentLine = 0;
    public int charactime;
    public string name2;
    private LoadNewArea lna;
    public TextAsset textFile;
    public string[] textLines;
    public int i = 0;



    // Use this for initialization
    void Start() {
        lna = new LoadNewArea();
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n', ';'));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (i < textLines.Length-1)
        {
            int pic = int.Parse(textLines[i + 2]);
            dText.text = textLines[i] + ": " + textLines[i + 1];
            image.GetComponent<Image>().sprite = images[pic];

        }
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;
            charactime++;
            i += 3;
        }


        if (currentLine > textLines.Length/3-1)
        {
            dBox.SetActive(false);
            dialogActive = false;

           
            charactime = 0;
            Debug.Log(name);
            if (name2 == "Assistant")
            {
                lna.loadFromDialogue(name2);
            }
           
        }

        
        
    }

    public void showDialogue(string name1)
    {
        dialogActive = true;
        dBox.SetActive(true);
        name2 = name1;
    }
}
