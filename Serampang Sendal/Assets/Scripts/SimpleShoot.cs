using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject peluruSandal;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot(){
        Instantiate(peluruSandal, firePoint.position, firePoint.rotation);
    }
}
