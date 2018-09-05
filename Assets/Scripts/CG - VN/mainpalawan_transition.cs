using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainpalawan_transition : MonoBehaviour {

    private bool playerEnter;
    public cgManager cgman;
    private bool istriggered;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    private LoadNewArea lna;

    // Use this for initialization
    void Start () {
        lna = new LoadNewArea();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E) && playerEnter)
        {
            cgman.textLines = lines;
            cgman.textimage = img;
            cgman.textName = charac;
            cgman.images = images;

            if (!cgman.cgActive)
            {

                cgman.currentLine = 0;
                cgman.showDialogue();
                istriggered = true;

            }

        }
        if (!cgman.cgActive && istriggered)
        {
            lna.loadFromDialogue("palawan");
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
}
