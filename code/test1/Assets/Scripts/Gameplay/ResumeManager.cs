using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeManager : MonoBehaviour
{
    public GameObject PauseButton;
    public GameObject ResumeButton;

    void Start()
    {
        ResumeButton.SetActive(false);
    }

    public void Resume()
    {
        PauseButton.SetActive(true);
        ResumeButton.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
