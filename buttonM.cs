﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void level1()
    {
        SceneManager.LoadScene("level1");
    }
    public void controls()
    {
        SceneManager.LoadScene("controls");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
