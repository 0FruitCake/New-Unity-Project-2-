using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutSide3Trigger : MonoBehaviour {

    // Use this for initialization
  

   
    private bool playerEnter;

  
    public bool istriggered;

    public zoneController zct;
  




    // Use this for initialization
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if (playerEnter)
        {
            zct.battleOn(false);
            zct.zone1State(true);

        }


        if (istriggered)
        {


            transform.gameObject.SetActive(false);

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerEnter = true;


        }
    }
}
