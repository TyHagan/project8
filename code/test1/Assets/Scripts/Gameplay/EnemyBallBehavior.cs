using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBallBehavior : MonoBehaviour
{
    public float WindForce = 10;

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wind")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * WindForce);
        }
    }
}
