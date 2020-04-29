using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeCountAndDie : MonoBehaviour
{
    public bool TouchingEnemy = false;
    public bool IsInvincible;
    public int LocalLiveCount = 3;

    public AudioSource HitSound;

    public GameObject HeartOne;
    public GameObject HeartTwo;
    public GameObject HeartThree;
    public GameObject Invincible;
    public GameObject IPUParticles;

    public float StartTime;
    public float CountTime;

    void Start()
    {
        StartTime = 3;
        Invincible.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TouchingEnemy = true;
        }
    }

    void Update()
    {
        HeartOne.SetActive(LocalLiveCount > 0);
        HeartTwo.SetActive(LocalLiveCount > 1);
        HeartThree.SetActive(LocalLiveCount > 2);

        if (CountTime >= 0)
        {
            CountTime -= Time.deltaTime;
        }
        else
        {
            Invincible.SetActive(false);
            IsInvincible = false;
            IPUParticles.SetActive(false);

        }
        if (TouchingEnemy == true)
        {

            if (CountTime <= 0.2)
            {
                HitSound.Play();
                LocalLiveCount -= 1;
                CountTime = StartTime;
                Invincible.SetActive(true);
                IsInvincible = true;
            }
        }

        if (LocalLiveCount < 1)
        {
            Application.LoadLevel("Game Over");
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
