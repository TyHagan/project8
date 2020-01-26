using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{

    public movePlayer thePlayer;

    private Vector2 lastPlayerPosition;
    private float distanceToMove;

    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        //Basically just repeats the function spawn
        //      InvokeRepeating("spawn", 0, 4);
        Invoke("spawn", 4);

        thePlayer = FindObjectOfType<movePlayer>();
        lastPlayerPosition = thePlayer.transform.position;

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
        /*       GameObject newBall = (GameObject) Instantiate(Ball) as GameObject;

               distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;
               newBall.transform.position = new Vector2(transform.position.x, transform.position.y + distanceToMove + 50);
               lastPlayerPosition = thePlayer.transform.postition;
               */


        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
    }
    
}
