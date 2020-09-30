using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
    
{
    public GameObject PoP;
    public PlayerMovement player;

    void OnTriggerEnter(Collider other)
    {
        //Set player dalam range
        if (other.gameObject == PoP)
        {
            player.PoweerUP();
            Destroy(gameObject);
            
        }
    }
}
