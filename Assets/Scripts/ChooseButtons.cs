using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseButtons : MonoBehaviour {

    public GameObject btn1;
    public GameObject btn2;
    public GameObject dmng;
    public DialogueManager dman;
    public int count ;


    public void choice1() {
        Debug.Log(name);
        if (dman.name2 == "Assistant")
        {
            dman.lna.loadFromDialogue(dman.name2);
        }
        count = 1;
    }
    public void choice2()
    {
        btn1.SetActive(false);
        btn2.SetActive(false);
        count = 1;
    

      
    }

    void Update () {
        if (count == 1)
        {
            btn1.SetActive(false);
            btn2.SetActive(false);
        }
      
		
	}
}
