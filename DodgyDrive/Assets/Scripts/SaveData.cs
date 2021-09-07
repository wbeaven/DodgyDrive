using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public void Save()
    {
        PlayerPrefs.SetInt("L1C", StaticData.levelOneComplete);
        PlayerPrefs.SetInt("L1SQ", StaticData.levelOneSas);
        PlayerPrefs.SetInt("L1P", StaticData.levelOnePath);
        PlayerPrefs.SetInt("L1S", StaticData.levelOneStars);
    }
    public void Load()
    {
        StaticData.levelOneComplete = PlayerPrefs.GetInt("L1C");
        StaticData.levelOneSas = PlayerPrefs.GetInt("L1SQ");
        StaticData.levelOnePath = PlayerPrefs.GetInt("L1P");
        StaticData.levelOneStars = PlayerPrefs.GetInt("L1S");
    }
}