/*
    Pause Menu Controller
    Author: Gerald Anthony, Jr.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]private GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            if(Time.timeScale == 1){
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            } else if(Time.timeScale == 0){
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
    }

}
