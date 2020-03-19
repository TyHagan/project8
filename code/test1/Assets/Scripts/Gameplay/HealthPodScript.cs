using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPodScript : MonoBehaviour
{
    public GameObject HealthPod;
    public GameObject PlayerSprite;
    public int AddedHealth = 1;
    PlayerLifeCountAndDie LifeScript;

    // Start is called before the first frame update
    void Start()
    {
        LifeScript = PlayerSprite.GetComponent<PlayerLifeCountAndDie>();

        if(Random.Range(1,10) == 7)
        {
            HealthPod.SetActive(true);
        }
        else
        {
            HealthPod.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if(LifeScript.LocalLiveCount <= 2)
            {
                LifeScript.LocalLiveCount += AddedHealth;
                HealthPod.SetActive(false);
            }
        }
    }
}
