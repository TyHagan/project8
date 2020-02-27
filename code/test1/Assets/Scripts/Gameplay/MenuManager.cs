using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuButton;

    void Start()
    {
        MenuButton.SetActive(false);
    }

    public void Menu()
    {
        MenuButton.SetActive(false);
        Time.timeScale = 1.0f;
        Application.LoadLevel("TitlePage");
    }
}
