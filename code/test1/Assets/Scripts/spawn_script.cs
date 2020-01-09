﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        //Basically just repeats the function spawn
        //      InvokeRepeating("spawn", 0, 4);
        Invoke("spawn", 4);


        // Invoke("hello", 2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //definition of the function hello
    public void hello()
    {
        // KTH trying to print time
        Debug.Log("hello from hello():");

        Invoke("hello", Random.Range(1, 10));
    }

    //definition of the function spawn
    public void spawn()
    {
        // KTH trying to print time
        Debug.Log("hello from spawn():");
        Invoke("spawn", Random.Range(1, 10));

        //instantiates as a game object
        GameObject newBall = (GameObject) Instantiate(Ball) as GameObject;


        //perameters of where it should spawn
        //float x = Random.Range(30, 10);
        //float y = Random.Range(15, 25);

        float x = 80;
        float y = 45;

    // puts all of the floats and pus the newJoe into the float postions
        newBall.transform.position = new Vector2(x, y);
    //Vector2 has 2 axis (thats my guess) x and y. Vector3 has x, y, and z.
    }
    
}
