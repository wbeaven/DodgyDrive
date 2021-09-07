using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public GameObject firstStar;
    public GameObject secondStar;
    public GameObject thirdStar;

    public int isLevelComplete;
    public int isSasHit;
    public int stars;

    public bool starGot1 = false;
    public bool starGot2 = false;
    public bool starGot3 = false;

    private void Start()
    {
        isLevelComplete = StaticData.levelOneComplete;
        isSasHit = StaticData.levelOneSas;
        StaticData.levelOneStars = stars;
    }
    private void Update()
    {
        LevelOne();
    }
    public void LevelOne()
    {
        if (StaticData.levelOneComplete == 1 && starGot1 == false)
        {
            stars += 1;
            starGot1 = true;
        }
        if (StaticData.levelOneSas == 1 && starGot2 == false)
        {
            stars += 1;
            starGot2 = true;
        }
        if (StaticData.levelOnePath == 1 && starGot3 == false)
        {
            stars += 1;
            starGot3 = true;
        }

        if (stars == 1)
        {
            firstStar.SetActive(true);
        }
        if (stars == 2)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
        }
        if (stars == 3)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
            thirdStar.SetActive(true);
        }
    }
}
