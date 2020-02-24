﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Resume;

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        Menu.SetActive(false);
        Resume.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
