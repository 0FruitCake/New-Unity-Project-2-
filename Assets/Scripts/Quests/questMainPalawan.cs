using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questMainPalawan : MonoBehaviour {

    public string[] questTitle;
    public string[] questDesc;
    public string[] questProg;
    public bool[] isCompleted;
    public bool questActive;
    public int questIndex;
    public QuestManager qm;
    public Image questupdated;
    public int bananaCount;

	// Use this for initialization
	void Start () {
        
        questProg = new string[questTitle.Length];
        isCompleted = new bool[questTitle.Length];
	}
	
	// Update is called once per frame
	void Update () {
		if(questIndex == 2)
        {
         
            if(bananaCount == 10)
            {
                questCompleted();
            }
        }
	}

    public void questCompleted()
    {
        questupdated.gameObject.SetActive(true);
        isCompleted[questIndex] = true;
        questIndex++;
        
        Debug.Log(questIndex);
        
    }

    public void onClickMain()
    {
        Debug.Log("clicked");
        if (!questActive)
        {
            qm.questTitle.text = "";
            qm.questDesc.text = "Quest currently inactive";
            qm.questProg.text = "";
        }
        else
        {
            qm.questTitle.text = questTitle[questIndex];
            qm.questDesc.text = questDesc[questIndex];
            qm.questProg.text = questProg[questIndex];

            if (questIndex == 2)
            {
                questProg[questIndex] = "Banana Hands Collected : " + bananaCount + "/10";
                qm.questProg.text = questProg[questIndex];
           
            }
        }
    }

}
