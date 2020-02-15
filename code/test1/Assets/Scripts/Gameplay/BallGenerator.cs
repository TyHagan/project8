using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject theBall;
    public float MaxWait = 5;
    public float MinWait = 1;
    public float MaxChange = 5;
    public float MinChange = -5;
    private float RandomX;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y);
        InvokeRepeating("spawnEnemy", 0, Random.Range(MaxWait, MinWait));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnEnemy()
    {
        RandomX = Random.Range(MaxChange, MinChange);

        transform.position = new Vector3(transform.position.x + RandomX, transform.position.y, 0);

        Instantiate(theBall, transform.position, transform.rotation);

        transform.position = new Vector3(transform.position.x - RandomX, transform.position.y, 0);
    }
}
