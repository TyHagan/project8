using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();

        if(Input.GetKey(KeyCode.Keypad8) && Input.GetKey(KeyCode.L))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }
}
