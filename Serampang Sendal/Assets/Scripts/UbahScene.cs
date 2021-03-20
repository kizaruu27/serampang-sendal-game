using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UbahScene : MonoBehaviour
{
    void OnTriggerEnter (Collider other){
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.None;
    }


}
