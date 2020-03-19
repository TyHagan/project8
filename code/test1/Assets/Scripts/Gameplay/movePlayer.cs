using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private bool TouchingGround;
    private bool Jumpable;
    public bool Paused;

    public AudioSource jump;
    public float WindForce = 30;

    public float Speed = 1;
    public float JumpMultiplier = 1;
    public float PowerUpTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        TouchingGround = false;
        Jumpable = false;
        Paused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Paused == false)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.left * 20f * Speed);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.right * 20f * Speed);
            }

            if (TouchingGround == true)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (Jumpable == true)
                    {
                        Rigidbody2D rb = GetComponent<Rigidbody2D>();
                        rb.AddForce(Vector2.up * 800f * JumpMultiplier);
                        jump.Play();
                        Jumpable = false;
                    }
                }
            }

            if (PowerUpTime > 0)
            {
                PowerUpTime -= Time.deltaTime;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.name == "Destroyer")
        {
            TouchingGround = true;
            Jumpable = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.name == "Destroyer")
        {
            TouchingGround = false;
            Jumpable = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wind")
        {
            if(Paused == false)
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.up * WindForce);
            }
        }
    }
}
