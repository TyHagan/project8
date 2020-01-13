using UnityEngine;
using System.Collections;

public class TestMove : MonoBehaviour
{
    public float carSpeed = 10f;
//    public float maxpos = 2.2f;
    Vector3 position;


    // Use this for initialization
    void Start()
    {

        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
//        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;
    }
}