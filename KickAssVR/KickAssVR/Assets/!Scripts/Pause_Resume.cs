using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause_Resume : MonoBehaviour
{

    GameObject pauseMenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenuCanvas = GameObject.FindGameObjectWithTag("pause");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPauseState()
    {
        if(PauseMenu.isMenu)
        {
            PauseMenu.isPaused = false;
        }
        else
        {
            PauseMenu.isPaused = true;
        }
    }
}
