using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendal : MonoBehaviour
{
    public float point = 0;
    public Animator anim;
        //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider sandal) {
        if(sandal.CompareTag("Peluru")){
            anim.SetBool("HitDia", true);
            point += 1;
            Debug.Log("Nambah 1");
        }else
        {
            anim.SetBool("HitDia", false);
        }
    }
}
