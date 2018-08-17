using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Animator anim;
    private bool playerMoving;
    public Vector2 lastMove;
    public Rigidbody2D myRigidbody;

    public Transform location;
    public bool cutscene;

    public bool canMove;
    private ScreenFader sf;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        sf = FindObjectOfType<ScreenFader>();

    }

    // Update is called once per frame
    void Update()
    {
        if (sf.isFading)
        {
            canMove = false;
        }
        else
        {
            canMove = true;
        }


        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            anim.SetBool("PlayerMoving", false);
            return;
        }

        if (cutscene)
        {
            transform.position = Vector2.MoveTowards(transform.position, location.position, moveSpeed * Time.deltaTime);
            playerMoving = true;
            lastMove.x = -((transform.position.x - location.position.x)+1f);
            lastMove.y = -(transform.position.y - location.position.y);
        }

        else
        {
            playerMoving = false;
            if (Input.GetAxisRaw("Horizontal") > 0f || Input.GetAxisRaw("Horizontal") < -0f)
            {
                //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                playerMoving = true; ;
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < -0f)
            {
                //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }


  
}


