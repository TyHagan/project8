using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityCharacterScript : MonoBehaviour
{
    public GameObject ParticleBurst;

    public void MakeExplosion(Vector3 AtPos)
    {
        Instantiate(ParticleBurst, AtPos, transform.rotation);
    }
}
