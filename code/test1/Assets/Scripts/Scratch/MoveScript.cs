using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }


    // Update is called once per frame
    void Update()
    {
        float xpos = this.transform.position.x;
        float ypos = this.transform.position.y;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 position = this.transform.position;
            position.x = xpos + 0.5f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 position = this.transform.position;
            position.x = xpos - 0.5f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 position = this.transform.position;
            position.y = ypos + 0.5f;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 position = this.transform.position;
            position.y = ypos - 0.5f;
            this.transform.position = position;
        }

        
        /*
        // if (Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     Vector2 position = this.transform.position;
        //     position.y--;
        //     this.transform.position = position;
        // }
        */
    }
}
