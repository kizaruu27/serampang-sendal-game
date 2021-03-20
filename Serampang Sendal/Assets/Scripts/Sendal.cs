using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendal : MonoBehaviour
{
    public int point;
        //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider sandal) {
        if(sandal.CompareTag("Peluru")){
            point++;
            Debug.Log(point++);
            
        }
    }
}
