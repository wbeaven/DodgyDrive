using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crash : MonoBehaviour
{
    public GameObject loseScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
            HitTree();
    }

    void HitTree()
    {
        loseScreen.SetActive(true);
        GetComponent<LookAtMouse>().enabled = false;
        GetComponent<MoveToMouse>().enabled = false;
    }
}
