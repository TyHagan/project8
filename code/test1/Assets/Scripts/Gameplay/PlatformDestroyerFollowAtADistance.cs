using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyerFollowAtADistance : MonoBehaviour
{
    public Transform Target;
    public float DesiredDistance;
    public float DesiredX;
    private float DesiredY;
    private float MyY;
    private float DistanceToTarget;

    void Start()
    {
        DesiredY = Target.transform.position.y - DesiredDistance;
    }

    void Update()
    {
        MyY = transform.position.y;
        DistanceToTarget = Target.transform.position.y - MyY;
        if (DistanceToTarget > DesiredDistance)
        {
            DesiredY = Target.transform.position.y - DesiredDistance;
        }
        transform.position = new Vector3(DesiredX, DesiredY, transform.position.z);
    }
}