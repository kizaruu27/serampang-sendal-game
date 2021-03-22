using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPerfabs;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {   
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bulletPerfabs, firePoint.position, firePoint.rotation);
    }
}
