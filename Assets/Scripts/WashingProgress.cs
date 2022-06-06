using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingProgress : MonoBehaviour
{
    public WashingBar washingBar;
    private int maxProgress = 20;
    public int currentProgress;
    // Start is called before the first frame update
    void Start()
    {
        washingBar.SetMaxProgress(maxProgress);
        currentProgress = 0;
        washingBar.SetProgress(currentProgress);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void completeWash()
    {
        currentProgress += 2;
        
        washingBar.SetProgress(currentProgress);
    }
}
