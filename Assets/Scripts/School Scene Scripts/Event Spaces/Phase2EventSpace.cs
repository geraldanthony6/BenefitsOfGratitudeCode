using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sets up the sprites for NPCs of Obstacles phase 2 when entered
public class Phase2EventSpace : EventSpace
{

    //NPC GameObjects
    public GameObject teacher;
    public GameObject teacher2;
    public GameObject student1;
    public GameObject student2;
    public GameObject student3;
    public GameObject student4;
    public GameObject student5;

    //NPC Sprites
    public Sprite teacher2Sprite;
    public Sprite student1Sprite;
    public Sprite student2Sprite;
    public Sprite student3Sprite;
    public Sprite student4Sprite;
    public Sprite student5Sprite;

    //Changes the sprites for NPCs that have been moved
    public override void OnEnter()
    {
        Debug.Log("Phase 2");
        //disable animators
        teacher2.GetComponent<Animator>().enabled = false;
        student1.GetComponent<Animator>().enabled = false;
        student2.GetComponent<Animator>().enabled = false;
        student3.GetComponent<Animator>().enabled = false;
        student4.GetComponent<Animator>().enabled = false;
        student5.GetComponent<Animator>().enabled = false;
        //ready sprites for gym cutscene
        teacher2.GetComponent<SpriteRenderer>().sprite = teacher2Sprite;
        student1.GetComponent<SpriteRenderer>().sprite = student1Sprite;
        student2.GetComponent<SpriteRenderer>().sprite = student2Sprite;
        student3.GetComponent<SpriteRenderer>().sprite = student3Sprite;
        student4.GetComponent<SpriteRenderer>().sprite = student4Sprite;
        student5.GetComponent<SpriteRenderer>().sprite = student5Sprite;
        //ready new teacher
        teacher.SetActive(false);
        gameObject.SetActive(false);
    }
}
