using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.left * 20f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.right * 20f);
        }

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.up * 800f);
            }
           
        }
    }
}
