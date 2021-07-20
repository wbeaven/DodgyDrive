using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sasquatch : MonoBehaviour
{
    public GameObject sasquatch;
    public Rigidbody sasquatchBody;
    public float sasplosionForce;
    public float sasplosionSize;
    public float sasplosionUp;
    public GameObject sasplosionPos;

    public bool isLevel1;
    public bool isLevel2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isLevel1 == true)
                StaticData.levelOneSas = 1;
            sasquatch.SetActive(true);
            sasquatchBody.AddExplosionForce(sasplosionForce, sasplosionPos.transform.position, sasplosionSize, sasplosionUp, ForceMode.Impulse);
        }
    }
}
