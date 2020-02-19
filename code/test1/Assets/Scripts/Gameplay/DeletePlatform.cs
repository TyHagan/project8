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
        Debug.Log("DeletePlatform");
        Destroy(col.gameObject);
    }
}
