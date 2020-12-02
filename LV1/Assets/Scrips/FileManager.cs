using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    public GameObject[] File, Tip;
    Color EnbleButton = new Color(116,255,0,225);
    Color UnenbleButton = new Color(255, 255, 255, 255);
    int x=-1;
    void Update()
    {
        
        if (Input.GetButtonDown("XboxRB")&&File[0].activeSelf)
        {
            x += 1;
        }
        ChangeColor();

    }
    void ChangeColor()
    {
        switch (x)
        {
            case 1:
                File[x].GetComponent<Image>().color = EnbleButton;
                File[x-1].GetComponent<Image>().color = UnenbleButton;
                File[x].SetActive(true);
                Tip[x].SetActive(true);
                Tip[x-1].SetActive(false);
                break;

            case 0:
                File[x].GetComponent<Image>().color = EnbleButton;
                Tip[x].SetActive(true);
                break;

        }
    }
}
