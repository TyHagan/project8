using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject theBall;
    public float maxWait;
    public float minWait;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y);
        InvokeRepeating("spawnEnemy", 0, Random.Range(maxWait, minWait));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnEnemy()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        Instantiate(theBall, transform.position, transform.rotation);
    }
}
