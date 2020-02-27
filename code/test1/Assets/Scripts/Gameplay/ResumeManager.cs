using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeManager : MonoBehaviour
{
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public GameObject MenuButton;

    void Start()
    {
        ResumeButton.SetActive(false);
    }

    public void Resume()
    {
        PauseButton.SetActive(true);
        ResumeButton.SetActive(false);
        MenuButton.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
