using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeCountAndDie : MonoBehaviour
{
    public bool TouchingEnemy = false;
    public int LocalLiveCount = 3;

    public AudioSource HitSound;

    public GameObject HeartOne;
    public GameObject HeartTwo;
    public GameObject HeartThree;
    public GameObject Invincible;
    public float StartTime;
    public float CountTime;

    void Start()
    {
        StartTime = 3;
        Invincible.SetActive(false);
    }

    void Update()
    {
        if(CountTime >= 0)
        {
            CountTime -= Time.deltaTime;
        }
        else
        {
            Invincible.SetActive(false);
        }
        if (TouchingEnemy == true)
        {

            if(CountTime <= 0.2)
            {
                HitSound.Play();
                 LocalLiveCount -= 1;

                 if (LocalLiveCount == 1)
                 {
                    HeartOne.SetActive(true);
                    HeartTwo.SetActive(false);
                    HeartThree.SetActive(false);
                 }
                 else
                 {
                    if (LocalLiveCount == 2)
                    {
                        HeartOne.SetActive(true);
                        HeartTwo.SetActive(true);
                        HeartThree.SetActive(false);
                    }
                    else
                    {
                        if (LocalLiveCount == 3)
                        {
                            HeartOne.SetActive(true);
                            HeartTwo.SetActive(true);
                            HeartThree.SetActive(true);
                        }
                    }
                 }

                CountTime = StartTime;
                Invincible.SetActive(true);
            }
        }

        if (LocalLiveCount < 1)
        {
            Application.LoadLevel("Game Over");
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
}
