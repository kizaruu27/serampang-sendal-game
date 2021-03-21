using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sendal : MonoBehaviour
{
    public float point = 0;
    public int angka;
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
        Debug.Log(sandal.tag);
        if(sandal.tag == "Peluru"){
            point += 1;
            angka += 1;
            Debug.Log("Nambah 1");
            PlayerPrefs.SetInt("Skor", angka);
            //anim.SetBool("HitDia", true);
        }else
        {
            anim.SetBool("HitDia", false);
        }
    }
}
