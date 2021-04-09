using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool playerHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Tree"))
        {
            playerHit = true;
        }
    }

    private void Update()
    {
        if (playerHit == true)
        {

        }
    }
}
