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
        // void OnTriggerEnter(Collider amunisi) {
        // if (amunisi.CompareTag("Sandal")){
        //     score++;
        //     amunisi.GetComponent<Shooter>().ammo += 1;
        //     Debug.Log(amunisi.GetComponent<Shooter>().ammo);
        // }
        // }
    }
    void OnTriggerEnter(Collider akunisi) {
        if (akunisi.CompareTag("Sandal"))
        {
            Destroy(gameObject);
        }
    }
  
}


