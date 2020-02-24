﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeCountAndDie : MonoBehaviour
{
    public bool TouchingEnemy = false;
    public int LocalLiveCount = 3;
    public int Invincible = 0;

    public GameObject HeartOne;
    public GameObject HeartTwo;
    public GameObject HeartThree;

    void Start()
    {
        InvokeRepeating("WaitFiveSeconds", 0, .001f);
    }

    void Update()
    {
        if (TouchingEnemy == true)
        {
            if (Invincible == 0)
            {
                LocalLiveCount -= 1;

                if(LocalLiveCount == 1)
                {
                    HeartOne.SetActive(true);
                    HeartTwo.SetActive(false);
                    HeartThree.SetActive(false);
                }
                else
                {
                    if(LocalLiveCount == 2)
                    {
                        HeartOne.SetActive(true);
                        HeartTwo.SetActive(true);
                        HeartThree.SetActive(false);
                    }
                    else
                    {
                        if(LocalLiveCount == 3)
                        {
                            HeartOne.SetActive(true);
                            HeartTwo.SetActive(true);
                            HeartThree.SetActive(true);
                        }
                    }
                }

                Invincible = 1;
                StartCoroutine(WaitFiveSeconds());
            }
        }

        if (LocalLiveCount < 1)
        {
            Application.LoadLevel("Game Over");
        }

        if (Invincible == 1)
        {
            StartCoroutine(WaitFiveSeconds());
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TouchingEnemy = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TouchingEnemy = false;
        }
    }

    IEnumerator WaitFiveSeconds()
    {
        yield return new WaitForSeconds(5);
        Invincible = 0;
    }
}
