using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDetection : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpeedPU;
    public GameObject SpeedTrail;
    public GameObject InvinciblePU;
    public GameObject InvincibilityParticles;

    public Vector3 CurrentPos;

    public float PowerUpActiveTime = 5;

    movePlayer PlayerMoveScript;
    SpeedPowerUpScript PowerUpScriptVar;
    InvincibilityCharacterScript IPUScript;
    PlayerLifeCountAndDie PlayerLifeScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMoveScript = Player.GetComponent<movePlayer>();
        PowerUpScriptVar = SpeedPU.GetComponent<SpeedPowerUpScript>();
        PlayerLifeScript = Player.GetComponent<PlayerLifeCountAndDie>();
        IPUScript = InvinciblePU.GetComponent<InvincibilityCharacterScript>();

        SpeedTrail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMoveScript.PowerUpTime <= 0)
        {
            PlayerMoveScript.Speed = 1;
            SpeedTrail.SetActive(false);
            PlayerMoveScript.JumpMultiplier = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "SpeedPower")
        {
            //CurrentPos = new Vector3(PowerUpScriptVar.MyPosition.x, PowerUpScriptVar.MyPosition.y, PowerUpScriptVar.MyPosition.z);
            CurrentPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Debug.Log("Cur X: " + CurrentPos.x + "; Y: " + CurrentPos.y + "; Z: " + CurrentPos.z);
            PowerUpScriptVar.MakeDieParticles(CurrentPos);
            PlayerMoveScript.PowerUpTime = PowerUpActiveTime;
            PlayerMoveScript.Speed = 2;
            PlayerMoveScript.JumpMultiplier = 1.3f;
            SpeedTrail.SetActive(true);
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "InvincibilityPower")
        {
            CurrentPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            IPUScript.MakeExplosion(CurrentPos);
            PlayerLifeScript.IsInvincible = true;
            PlayerLifeScript.CountTime = 10;
            InvincibilityParticles.SetActive(true);
            Destroy(col.gameObject);
        }
    }
}
