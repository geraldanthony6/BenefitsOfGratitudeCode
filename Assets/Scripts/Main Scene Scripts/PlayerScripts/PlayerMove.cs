using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script which moves the player character on user input
//Authors: Charlie Christakos
//         Gerald Anthony, Jr.
public class PlayerMove : MonoBehaviour {

    //rigidbody of player
    public Rigidbody2D rb;
    //speed at which player moves
    public float moveSpeed = 5f;

    //animator of player
    private Animator animator;
    //the next idle animation to play
    private string nextIdle;

    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        nextIdle = "StandingDown";
    }

	// Update is called once per frame
	void Update () {
        //reads input from WASD or arrow keys
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        switch (Input.GetAxisRaw("Horizontal"))
        {
            case 1:
                ClearAnimations();
                animator.SetTrigger("WalkingRight");
                nextIdle = "StandingRight";
                break;
            case -1:
                ClearAnimations();
                animator.SetTrigger("WalkingLeft");
                nextIdle = "StandingLeft";
                break;
            case 0:
                switch (Input.GetAxisRaw("Vertical"))
                {
                    case 1:
                        ClearAnimations();
                        animator.SetTrigger("WalkingUp");
                        nextIdle = "StandingUp";
                        break;
                    case -1:
                        ClearAnimations();
                        animator.SetTrigger("WalkingDown");
                        nextIdle = "StandingDown";
                        break;
                    case 0:
                        ClearAnimations();
                        animator.SetTrigger(nextIdle);
                        break;
                }
                break;
        }
    }

    // Update is called 50 times per second
    void FixedUpdate()
    {
        //creates movement from input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void ClearAnimations()
    {
        animator.ResetTrigger("WalkingDown");
        animator.ResetTrigger("WalkingUp");
        animator.ResetTrigger("WalkingLeft");
        animator.ResetTrigger("WalkingRight");
        animator.ResetTrigger("StandingDown");
        animator.ResetTrigger("StandingUp");
        animator.ResetTrigger("StandingLeft");
        animator.ResetTrigger("StandingRight");
    }
}
