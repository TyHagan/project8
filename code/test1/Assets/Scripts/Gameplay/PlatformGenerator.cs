using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject[] PlatformList;
    public GameObject[] PowerUps;
    public GameObject LevelMarkerCanvas;

    public Transform generationPoint;

    public float distanceBetween;
    private int RandomPlatform = 2;
    private int index;
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
                index = Random.Range(0, PowerUps.Length);
            }

            if (Platforms > 2)
            {
                if(Platforms > 4)
                {
                    if(Platforms > 6)
                    {
                        RandomPlatform = Random.Range(0, 6);
                    }
                    else
                    {
                        RandomPlatform = Random.Range(0, 5);
                    }
                }
                else
                {
                    RandomPlatform = Random.Range(0, 3);
                }
            }
            else
            {
                RandomPlatform = 0;
            }

            transform.position = new Vector3(58.95f, transform.position.y + distanceBetween, 0);

            Instantiate(PlatformList[RandomPlatform], transform.position, transform.rotation);
            Platforms += 1;

            if (SpawnSPU == true)
            {
                Instantiate(PowerUps[index], SPUPos, transform.rotation);
            }

            if (Platforms == 5 || Platforms == 10 || Platforms == 25 || Platforms == 50 || Platforms == 100 || Platforms == 200)
            {
                MakeLevelMarker(Platforms);
            }
        }
    }

    void MakeLevelMarker(int Level)
    {
        GameObject CanvasSprite;
        Text LevelMarkerText;
        Vector3 MarkerSpawnPos;

        MarkerSpawnPos = new Vector3(78, transform.position.y, 3);
        CanvasSprite = Instantiate(LevelMarkerCanvas, MarkerSpawnPos, transform.rotation);
        LevelMarkerText = CanvasSprite.GetComponentInChildren<Text>();
        LevelMarkerText.text = "L E V E L  " + Level;
    }
}
