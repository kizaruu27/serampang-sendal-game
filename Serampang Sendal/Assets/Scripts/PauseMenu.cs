using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPause = false;
    public GameObject pauseMenuUI;
    public GameObject Crosshair;
    GameObject FPS = GameObject.FindWithTag("Player");

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Crosshair.SetActive(true);
        AudioListener.volume = 1f;
        FPS.GetComponent<MouseLook>().enabled = true;
        FPS.GetComponent<Shooter>().enabled = true;
        FPS.GetComponent<PlayerMovement>().enabled = true;
        GameIsPause = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Crosshair.SetActive(false);
        AudioListener.volume = 0f;
        FPS.GetComponent<MouseLook>().enabled = false;
        FPS.GetComponent<Shooter>().enabled = false;
        FPS.GetComponent<PlayerMovement>().enabled = false;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
