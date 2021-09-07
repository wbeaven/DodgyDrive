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
    public GameObject sasSound;

    public float timer;
    public bool slowMotion = false;

    public bool isLevel1;
    public bool isLevel2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slowMotion = true;
            if (isLevel1 == true)
                StaticData.levelOneSas = 1;
            sasquatch.SetActive(true);
            sasSound.SetActive(true);
            sasquatchBody.AddExplosionForce(sasplosionForce, sasplosionPos.transform.position, sasplosionSize, sasplosionUp, ForceMode.Impulse);
        }
    }
    private void Update()
    {
        SpeedUp();
        SlowDown();
    }

    private void SpeedUp()
    {
        if (slowMotion)
        {
            timer += 1 * Time.deltaTime;
            Time.timeScale = .5f;
        }
        else
            Time.timeScale = 1f;
    }
    private void SlowDown()
    {
        if (timer >= 1)
            slowMotion = false;
    }
}