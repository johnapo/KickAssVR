using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string levelSelect;
    public string mainMenu;
    public string credits;
    public static bool isMenu;
    public static bool isPaused;
    public static bool isSettings;
 //   public GameObject pauseMenuCanvas;
    GameObject pauseMenuCanvas;
    public GameObject SettingsCanvas;
    public GameObject player;
   // public FirstPersonController firstPersonController;

        void Start()
    {
        pauseMenuCanvas = GameObject.FindGameObjectWithTag("pause");
    }

    // Update is called once per frame
    void Update () {

        if(!isPaused && !isSettings)
        {
            Time.timeScale = 1f;
        }

		if(isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        
        }

        if(Input.GetKeyDown(KeyCode.Escape) && !isMenu)
        {
            Cursor.lockState = CursorLockMode.None;
            if (isSettings)
            {
                isSettings = !isSettings;
            }
            else
            {
                isPaused = !isPaused;
            }
        }

        if (isSettings)
        {
            pauseMenuCanvas.SetActive(false);
            SettingsCanvas.SetActive(true);
         //   Time.timeScale = 0f;
            
        }
        else
        {
            SettingsCanvas.SetActive(false);
         //   Time.timeScale = 0f;
           
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Pause()
    {
        isPaused = true;
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
        isPaused = !isPaused;
        if (isSettings)
        {
            isSettings = !isSettings;
        }
        //       Time.timeScale = 1f;
    }

    public void Quit()
    {
        SceneManager.LoadScene(mainMenu);
        isPaused = !isPaused;
        if (isSettings)
        {
            isSettings = !isSettings;
        }
    }

    public void Credits()
    {
        SceneManager.LoadScene(credits);
        isPaused = !isPaused;
        if (isSettings)
        {
            isSettings = !isSettings;
        }
    }

    public void Settings()
    {
        isSettings = !isSettings;
    }


}
