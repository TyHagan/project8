﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_ball : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("In void collision");
        if (col.gameObject.name == "Ball(Clone)")
        {
            Debug.Log("In if then");
            Destroy(col.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("In start");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
