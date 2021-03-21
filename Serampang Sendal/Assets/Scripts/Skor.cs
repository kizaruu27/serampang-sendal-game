using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public float scoreAmount;
    public float pointPerSecont;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointPerSecont = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Meter";
        scoreAmount += pointPerSecont *Time.deltaTime;
        
    }
}
