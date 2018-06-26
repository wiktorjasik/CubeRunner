using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuButton;
    public GameObject rightButton, leftButton;
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            CallPauseMenu();
        }
    }

    public void CallPauseMenu()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseMenuButton.SetActive(true);
        if (Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);
        }
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuButton.SetActive(false);
        if (Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(false);
            leftButton.SetActive(false);
        }
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Resume();
    }
}
