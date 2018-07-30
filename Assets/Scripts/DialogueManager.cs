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
    public Sprite boy;
    public Sprite girl;
    public Image curimage;
    public int currentLine;
    public int charactime;
    public string name2;
    private LoadNewArea lna;

    // Use this for initialization
    void Start() {
        lna = new LoadNewArea();
    }

    // Update is called once per frame
    void Update() {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        { 
            currentLine++;
            charactime++;
        }

       
        if (currentLine >= dialogLines.Length) {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
            charactime = 0;
            Debug.Log(name);
            if(name2 == "Assistant")
            {
                lna.loadFromDialogue(name2);
            }
        }

        dText.text = dialogLines[currentLine];
        if (charactime == 2)
        {
            image.GetComponent<Image>().sprite = girl;
        }
        else
        {
            image.GetComponent<Image>().sprite = boy;
        }
    }

    public void showDialogue(string name1)
    {
        dialogActive = true;
        dBox.SetActive(true);
        name2 = name1;
    }
}
