using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public GameObject loseScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
            Crash();
    }

    void Crash()
    {
        //loseScreen.SetActive = true;
    }
}
