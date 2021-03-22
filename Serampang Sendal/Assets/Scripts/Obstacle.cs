using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {

    PlayerMovement playerMovement;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
	}

    private void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Players") {
            SceneManager.LoadScene("GameOver");
            // Kill the player
            playerMovement.gameover();
            Debug.Log("Kena");
        }
    }
}