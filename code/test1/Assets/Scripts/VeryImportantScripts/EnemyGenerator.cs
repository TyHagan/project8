using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 40);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(58.95f, transform.position.y + distanceBetween, 0);

            Instantiate(thePlatform, transform.position, transform.rotation);
        }
    }
}
