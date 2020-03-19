using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeManager : MonoBehaviour
{
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public GameObject MenuButton;

    public GameObject Player;
    movePlayer MoveScript;

    void Start()
    {
        ResumeButton.SetActive(false);
        MoveScript = Player.GetComponent<movePlayer>();
    }

    public void Resume()
    {
        PauseButton.SetActive(true);
        ResumeButton.SetActive(false);
        MenuButton.SetActive(false);
        Time.timeScale = 1.0f;
        MoveScript.Paused = false;
    }
}
