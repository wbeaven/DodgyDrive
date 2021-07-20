using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject element;
    public bool isOpen = false;
    public void Both()
    {
        if (isOpen == false)
        {
            element.SetActive(true);
            isOpen = true;
        }
        else
        {
            element.SetActive(false);
            isOpen = false;
        }
    }
}
