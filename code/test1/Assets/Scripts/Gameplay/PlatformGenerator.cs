using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform1;
    public GameObject thePlatform2;
    public GameObject thePlatform3;
    public GameObject thePlatform4;
    public GameObject thePlatform5;
    public GameObject thePlatform6;

    public GameObject SpeedPowerUpSprite;

    public Transform generationPoint;

    public float distanceBetween;
    private int RandomPlatform = 2;
    private int Platforms;
    private int SpeedPowerUpChance;

    public int MaxXRandom;
    public int MinXRandom;
    private int RandomSPUX;

    private bool SpawnSPU;

    private Vector3 SPUPos;
    private Vector3 SavedResetPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 40);
    }

    // Update is called once per frame
    void Update()
    {
        SPUPos = new Vector3(76.9f, transform.position.y, transform.position.z);
        SavedResetPos = SPUPos;

        if (transform.position.y < generationPoint.position.y)
        {
            SpawnSPU = false;

            SpeedPowerUpChance = Random.Range(1, 10);

            if (SpeedPowerUpChance == 7)
            {
                RandomSPUX = Random.Range(MinXRandom, MaxXRandom);
                SpawnSPU = true;
                SPUPos = SavedResetPos;
                SPUPos = new Vector3(SavedResetPos.x + RandomSPUX, SavedResetPos.y + 50, transform.position.z);
            }

            if (Platforms > 2)
            {
                if(Platforms > 4)
                {
                    if(Platforms > 6)
                    {
                        RandomPlatform = Random.Range(1, 7);
                    }
                    else
                    {
                        RandomPlatform = Random.Range(1, 6);
                    }
                }
                else
                {
                    RandomPlatform = Random.Range(1, 4);
                }
            }
            else
            {
                RandomPlatform = 1;
            }

            transform.position = new Vector3(58.95f, transform.position.y + distanceBetween, 0);
            
            if (RandomPlatform == 1)
            {
                Instantiate(thePlatform1, transform.position, transform.rotation);
                Platforms += 1;

                if (SpawnSPU == true)
                {
                    Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                }
            }
            else
            {
                if (RandomPlatform == 2)
                {
                    Instantiate(thePlatform2, transform.position, transform.rotation);
                    Platforms += 1;

                    if (SpawnSPU == true)
                    {
                        Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                    }
                }
                else
                {
                    if (RandomPlatform == 3)
                    {
                        Instantiate(thePlatform3, transform.position, transform.rotation);
                        Platforms += 1;

                        if (SpawnSPU == true)
                        {
                            Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                        }
                    }
                    else
                    {
                        if(RandomPlatform == 4)
                        {
                            Instantiate(thePlatform4, transform.position, transform.rotation);
                            Platforms += 1;

                            if (SpawnSPU == true)
                            {
                                Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                            }
                        }
                        else
                        {
                            if(RandomPlatform == 5)
                            {
                                Instantiate(thePlatform5, transform.position, transform.rotation);
                                Platforms += 1;

                                if (SpawnSPU == true)
                                {
                                    Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                                }
                            }
                            else
                            {
                                if(RandomPlatform == 6)
                                {
                                    Instantiate(thePlatform6, transform.position, transform.rotation);
                                    Platforms += 1;

                                    if (SpawnSPU == true)
                                    {
                                        Instantiate(SpeedPowerUpSprite, SPUPos, transform.rotation);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
