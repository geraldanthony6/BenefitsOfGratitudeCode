using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script which makes an NPC move between two different points
//Authors: Gerald Anthony, Jr.
public class NpcMove : MonoBehaviour
{
    //Store transform for startPoint
    public Transform startPoint;
    //Store transform for endPoint 
    public Transform endPoint;
    //Temp value to move from one point to the next
    private Vector3 nextPos;

    //Start position of NPC
    public Transform startPos;
    
    //Speed npc moves
    public float speed = 3f;

    //animator of NPC
    private Animator animator;
    //name of the animation that plays on the way to startPoint
    public string startAnimation;
    //mane of the animation that plays on the way to startPoint
    public string endAnimation;

    // Start is called before the first frame update
    void Start()
    {
        //Set next pos
        nextPos = startPos.position;
        //Set animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Call move method
        moveNPC();
    }

    //Method used to move NPC between two different points
    void moveNPC()
    {
        //check if npc position is equal to start point
        if(transform.position == startPoint.position)
        {
            //Set nextPos to end Point
            nextPos = endPoint.position;
            animator.Play(endAnimation);
            //check if npc position is equal to start point
        } else if(transform.position == endPoint.position)
        {
            //Set nextPos to start Point
            nextPos = startPoint.position;
            animator.Play(startAnimation);

        }

        //Move the npc from its current position to its next position based on where it is located now
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
