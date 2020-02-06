using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public movePlayer thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<movePlayer>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;    
    }
}
