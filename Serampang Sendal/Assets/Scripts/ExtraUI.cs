﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraUI : MonoBehaviour
{
    public int ammo;
    public bool isFiring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&& !isFiring && ammo>0)
        {
            isFiring = true;
            ammo--;
            isFiring = false;
        }
    }
}
