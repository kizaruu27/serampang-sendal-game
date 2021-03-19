using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject background;
    public GameObject about;

    public void aboutClicked()
    {
        background.SetActive(false);
        about.SetActive(true);
    }

    public void exitClicked()
    {
        Application.Quit();
    }

    public void backClicked()
    {
        background.SetActive(true);
        about.SetActive(false);
    }
}
