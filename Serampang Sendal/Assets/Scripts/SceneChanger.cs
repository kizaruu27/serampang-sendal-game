﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour
{
    public void Scene()
    {
        SceneManager.LoadScene("MainGameplay");
    }
}
