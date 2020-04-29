using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour
{
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Ground")
        {
            Destroy(col.gameObject);
        }
    }
}
