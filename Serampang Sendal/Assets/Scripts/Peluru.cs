using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{
     public float speed = 10f;
    public float destroy = 1f;
    private float timer;
    public int score;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = destroy;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Sandal"))
        {
            score += 1;
            Destroy(gameObject);
        }
    }
  
}


