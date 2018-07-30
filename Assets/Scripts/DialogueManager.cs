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

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            // dBox.SetActive(false);
            // dialogActive = false;
            currentLine++;
            charactime++;
        }
        if (currentLine >= dialogLines.Length) {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
            charactime = 0;
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

    public void showDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
        
    }
}
