using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadMenu(){
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCredits(){
        SceneManager.LoadScene(4);
    }

    public void LoadControls(){
        SceneManager.LoadScene(5);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
