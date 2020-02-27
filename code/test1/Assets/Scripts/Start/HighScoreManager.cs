using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text HighScore;
    public string LocalHighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
