using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class LeapCheck : MonoBehaviour
{

    public GameObject LeapCanvas;
    public Controller controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = new Controller();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.IsConnected)
        {
            LeapCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            LeapCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}