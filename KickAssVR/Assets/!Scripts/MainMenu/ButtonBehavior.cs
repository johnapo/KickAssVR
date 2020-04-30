using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject[] UIs;
    // Start is called before the first frame update
    void Start()
    {
        // forces the welcome screen to be the only active screen upon startup
        UIs[0].SetActive(true);
        for (int i = 1; i < UIs.Length - 1; i++)
        {
            UIs[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Upon left button press, the user will continue seeing UIs in counterclockwise order
    // 0->6->5->4->3->2->1->0
    public void Left()
    {
        // play left animation

        if (UIs[0].activeSelf == true)
        {
            UIs[0].SetActive(false);
            UIs[6].SetActive(true);
        }
        else if (UIs[1].activeSelf == true)
        {
            UIs[1].SetActive(false);
            UIs[0].SetActive(true);
        }
        else if (UIs[2].activeSelf == true)
        {
            UIs[2].SetActive(false);
            UIs[1].SetActive(true);
        }
        else if (UIs[3].activeSelf == true)
        {
            UIs[3].SetActive(false);
            UIs[2].SetActive(true);
        }
        else if (UIs[4].activeSelf == true)
        {
            UIs[4].SetActive(false);
            UIs[3].SetActive(true);
        }
        else if (UIs[5].activeSelf == true)
        {
            UIs[5].SetActive(false);
            UIs[4].SetActive(true);
        }
        else if (UIs[6].activeSelf == true)
        {
            UIs[6].SetActive(false);
            UIs[5].SetActive(true);
        }
        else
        {
            // do nothing; shouldn't come to this point
        }
    }

    // Upon right button press, the user will continue seeing UIs in clockwise order
    // 0->1->2->3->4->5->6->0
    public void Right()
    {
        // play right animation

        if (UIs[0].activeSelf == true)
        {
            UIs[0].SetActive(false);
            UIs[1].SetActive(true);
        }
        else if (UIs[1].activeSelf == true)
        {
            UIs[1].SetActive(false);
            UIs[2].SetActive(true);
        }
        else if (UIs[2].activeSelf == true)
        {
            UIs[2].SetActive(false);
            UIs[3].SetActive(true);
        }
        else if (UIs[3].activeSelf == true)
        {
            UIs[3].SetActive(false);
            UIs[4].SetActive(true);
        }
        else if (UIs[4].activeSelf == true)
        {
            UIs[4].SetActive(false);
            UIs[5].SetActive(true);
        }
        else if (UIs[5].activeSelf == true)
        {
            UIs[5].SetActive(false);
            UIs[6].SetActive(true);
        }
        else if (UIs[6].activeSelf == true)
        {
            UIs[6].SetActive(false);
            UIs[0].SetActive(true);
        }
        else
        {
            // do nothing; shouldn't come to this point
        }
    }

    // Loads scene corresponding to active UI element
    // should not do anything for welcome ui and unplayable scenes
    public void LevelSelect()
    {

        if (UIs[1].activeSelf == true)
        {
            // play successful button press sound
            SceneManager.LoadScene("Mod1_Tutorial");
        }
        else if (UIs[2].activeSelf == true)
        {
            // play successful button press sound
            SceneManager.LoadScene("Mod2_Tutorial");
        }
        /*
        else if (UIs[3].activeSelf == true)
        {
            // play successful button press sound
            SceneManager.LoadScene("Mod3_Tutorial");
        }
        else if (UIs[4].activeSelf == true)
        {
            // play successful button press sound
            SceneManager.LoadScene("Mod4_Tutorial");
        }
        else if (UIs[5].activeSelf == true)
        {
            // play successful button press sound
            SceneManager.LoadScene("Mod5_Tutorial");
        }
        */
        else if (UIs[6].activeSelf == true)
        {
            // play buh=bye sound
            Application.Quit();
        }
        else
        {
            // play unsuccessful sound
        }
        
    }


}
