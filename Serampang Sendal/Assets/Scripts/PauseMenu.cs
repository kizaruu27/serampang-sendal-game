using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool Paused = false;
    public GameObject ThePlayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel")
        {
            if (Paused == false)
            {
                Time.timeScale = 0;
                Paused = true;
                ThePlayer.GetComponent<PlayerMovement>().enabled = false;
                ThePlayer.GetComponent<Shooter>().enabled = false;
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1;
                Paused = false;
                ThePlayer.GetComponent<PlayerMovement>().enabled = true;
                ThePlayer.GetComponent<Shooter>().enabled = true;
                Cursor.visible = false;
            }
        }
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu..");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
