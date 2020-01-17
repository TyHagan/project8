﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
