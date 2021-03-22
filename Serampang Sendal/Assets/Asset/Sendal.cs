using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendal : MonoBehaviour
{
    Rigidbody rb;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider sandal) {
        if(sandal.CompareTag("Bullet")){
            Debug.Log("Aduh kena");
            // Destroy(gameObject);
            // Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
