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
    public int wolfcount;
    public int piratemax;
    
    private DialogueManager dMan;
    public string[] lines;
    public string[] charac;
    public string[] img;
    public Sprite[] images;
    public bool istriggered;
    public CompanionController theCompanion;
    public GameObject theTrader;
    public Transform cposition;
    public Transform tposition;
    public pirateController[] piratesc;


    // Use this for initialization
    void Start () {
        dMan = FindObjectOfType<DialogueManager>();

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

        if(questIndex == 5)
        {

            if (wolfcount == 3)
            {
                npcController npCont = GameObject.FindObjectOfType<npcController>().GetComponent<npcController>();
                npCont.set1State(false);
                npCont.set2State(true);
                zoneController zCont = GameObject.FindObjectOfType<zoneController>().GetComponent<zoneController>();
                zCont.zone1State(true);
                wolfcount = 0;
                questCompleted();

                
            }
        }
        if (questIndex == 7)
        {

            if (wolfcount == piratemax)
            {
                Debug.Log("in");
                for (int x = 0; x < piratesc.Length; x++)
                {
                    piratesc[x].canMove = false;
                }
                dMan.textLines = lines;
                dMan.textimage = img;
                dMan.textName = charac;
                dMan.img = img;
                dMan.images = images;

                if (!dMan.dialogActive && !istriggered)
                {
                    dMan.showDialogue();
                    dMan.currentLine = 0;  
                    istriggered = true;
                    wolfcount = 0;
                }
  
                
            }
            if (!dMan.dialogActive && istriggered)
            {
                
                StartCoroutine("restoretownstate");
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
    IEnumerator restoretownstate()
    {
        questCompleted();
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

        
        yield return StartCoroutine(sf.FadeToBlack());

        theCompanion.gameObject.SetActive(true);
        theCompanion.transform.position = cposition.position;
        theCompanion.canMove = false;
        npcController npCont = GameObject.FindObjectOfType<npcController>().GetComponent<npcController>();
        npCont.set1State(true);
        npCont.set2State(false);
        zoneController zCont = GameObject.FindObjectOfType<zoneController>().GetComponent<zoneController>();
        zCont.zone1State(false);
        theTrader.transform.position = tposition.position;
        
        yield return StartCoroutine(sf.FadeToClear());

    }
}
