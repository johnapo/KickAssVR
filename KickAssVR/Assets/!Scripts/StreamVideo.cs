using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class StreamVideo : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    bool introDone = false;
    bool defVidDone = false;
    bool moveOn = false;
    public VideoPlayer defVid;
    public VideoPlayer dmgVid;
    public AudioSource welcome;

    private AudioManager theAM;
    private AudioSource please;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartVid());

        /* Ok so like, I had to create a script called AudioManager. I stuck
         * this script on the Music gameobject. It's basically used to identify the object
         * using the "FindObjectOfType<AudioManager>();" line. I set AudioManager to this gameObject 
         * basically. Then I make an AudioSource variable named please, cause please help me god make this work.
         * I tell this AudioSource to take the component of that AudioManager's literal AudioSource. Now please
         * should literally be the AudioSource im trying to grab. Finally, i just set its volume to low so that it
         * isn't too loud while the videos play and whatnot. This literally took me for fucking ever, thank god for
         * my past scripts I made in 382 last year.
         */

        theAM = FindObjectOfType<AudioManager>();
        please = theAM.GetComponent<AudioSource>();
        please.volume = 0.1f;
        

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && introDone)
        {
            panel1.SetActive(true);
            StartCoroutine(RemoveVid());
            please.volume = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && defVidDone)
        {
            panel2.SetActive(true);
            StartCoroutine(RemoveVid2());
            please.volume = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && moveOn)
        {
            SceneManager.LoadScene("ModuleSelect");
        }

        defVid.playbackSpeed = Time.timeScale;
        dmgVid.playbackSpeed = Time.timeScale;
        //COMMENT BELOW LINE OUT TO NOT PAUSE WELCOME MSG ON PAUSE
        welcome.pitch = Time.timeScale;

    }

    //starts a timer
    //once timer ends, you can trigger def vid start
    IEnumerator StartVid()
    {
        yield return new WaitForSeconds(26);
        introDone = true;
        please.volume = 1f;
    }
    //once timer ends, def video turns off, cant be called again, and can now call dmgvid
    IEnumerator RemoveVid()
    {
        yield return new WaitForSeconds(120);
        panel1.SetActive(false);
        introDone = false;
        defVidDone = true;
        please.volume = 1f;
    }
    //once timers ends, dmg video turns off, cant be played again, and can now call to continie
    IEnumerator RemoveVid2()
    {
        yield return new WaitForSeconds(50);
        panel2.SetActive(false);
        defVidDone = false;
        moveOn = true;
        please.volume = 1f;
    }

    //FOR GESTURES
    public void startDefVid()
    {
        if (introDone)
        {
            panel1.SetActive(true);
            StartCoroutine(RemoveVid());
            please.volume = 0.1f;
        }

        else if (defVidDone)
        {
            panel2.SetActive(true);
            StartCoroutine(RemoveVid2());
            please.volume = 0.1f;
        }

        else if (moveOn)
        {
            SceneManager.LoadScene("ModuleSelect");
        }
    }

}
