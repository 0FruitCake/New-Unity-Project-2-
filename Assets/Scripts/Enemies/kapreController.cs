using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapreController : MonoBehaviour {

    public bool area1;
    public bool area2;
    public float cooldown1;
    public float cooldown2;
    public float aftercastdelay;
    public float castdelaytimer;
    public bool cancast;
    public bool casted;
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        area1 = false;
        area2 = false;
        cancast = false;
        casted = false;
        
    }
	
	// Update is called once per frame
	void Update () {


        if (!cancast)
        {
            anim.SetBool("isCasting", false);

            if (area1 == true || area2 == true && castdelaytimer <= 0 && casted == false)
            {
                
                cast();
            }

        }
        else
        {

            if (castdelaytimer > 0 && casted)
            {
                castdelaytimer -= Time.deltaTime;

            }
            if (castdelaytimer <= 0 && casted)
            {
                anim.SetBool("isCasting", false);
                cancast = false;
                casted = false;
            }
        }
       


           
        

       


    }

    public void cast()
    {
        anim.SetBool("isCasting", true);
        Debug.Log("Casted");
        castdelaytimer = aftercastdelay;
        
        casted = true;
        cancast = true;
        

    }
    public void castdelay()
    {

    }



}
