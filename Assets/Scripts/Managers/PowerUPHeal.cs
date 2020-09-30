using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPHeal : MonoBehaviour
{
    public GameObject PoP;
    public PlayerHealth player;

    void OnTriggerEnter(Collider other)
    {
        //Set player dalam range
        if (other.gameObject == PoP)
        {
            player.PowerUP();
            Destroy(gameObject);

        }
    }
}
