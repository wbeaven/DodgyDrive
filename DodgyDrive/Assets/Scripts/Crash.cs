using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crash : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject crashSound;
    public bool crashed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
            HitTree();
    }

    public void HitTree()
    {
        crashed = true;
        loseScreen.SetActive(true);
        GetComponent<LookAtMouse>().enabled = false;
        GetComponent<MoveToMouse>().enabled = false;
        crashSound.SetActive(true);
        GetComponent<MoveToMouse>().carSound.SetActive(false);
    }
}
