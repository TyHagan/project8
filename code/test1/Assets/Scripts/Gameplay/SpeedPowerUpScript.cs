using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpScript : MonoBehaviour
{
    public GameObject DiePowerUp;

    public Vector3 MyPosition;
    public float mx, my, mz;

    void Start()
    {
        MyPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.Log("Start X: " + MyPosition.x + "; Y: " + MyPosition.y + "; Z: " + MyPosition.z);
    }

    public void MakeDieParticles(Vector3 CurrentPosition)
    {
        Instantiate(DiePowerUp, CurrentPosition, transform.rotation);
    }
}

/*
MyPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
mx = transform.position.x;
        my = transform.position.y;
        mz = transform.position.z;
        //        Debug.Log("Start X: " + transform.position.x + "; Y: " + transform.position.y + "; Z: " + transform.position.z);
  //      Debug.Log("Start X: " + MyPosition.x + "; Y: " + MyPosition.y + "; Z: " + MyPosition.z);
        Debug.Log("Start X: " + mx + "; Y: " + my + "; Z: " + mz);


// MyPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
MyPosition = new Vector3(mx, my, mz);
Instantiate(DiePowerUp, MyPosition, transform.rotation);
//  Instantiate(DiePowerUp, transform.position, transform.rotation);
//      Debug.Log("MakeDieParticles X: " + Instance.MyPosition.x + "; Y: " + Instance.MyPosition.y + "; Z: " + Instance.MyPosition.z);
//       Debug.Log("MakeDieParticles X: " + MyPosition.x + "; Y: " + MyPosition.y + "; Z: " + MyPosition.z);
Debug.Log("MakeDieParticles X: " + mx + "; Y: " + my + "; Z: " + mz);
*/
