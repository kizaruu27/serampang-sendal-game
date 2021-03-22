using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public GameObject about;

    public void PlayGame (){
        SceneManager.LoadScene("MainGameplay");
    }

    public void QuitGame (){
        Debug.Log("KELUAR!!");
        Application.Quit();
    }

    public void BalikKeMenu (){
        SceneManager.LoadScene("MainMenu");
    }

   
}
