using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skor : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("Skor")){
            score = PlayerPrefs.GetInt("Skor");
        }
        
    }
}
