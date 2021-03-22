using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicSkrip : MonoBehaviour
{
    public void NextSceen (){
        SceneManager.LoadScene("MainMenu");
    }
}
