using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCDialogueTest : MonoBehaviour
{
    public GameObject player;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InitiateConversation();
    }

    void InitiateConversation()
    {
        distance = Vector2.Distance(player.transform.position, this.transform.position);
        if(distance <= 1.5)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
            SceneManager.LoadScene(3);
            }
        }
    }
    
}
