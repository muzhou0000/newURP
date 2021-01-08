using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Hardware;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    bool HaveUSB;
    public GameObject UI_USB,UI_Tip1;
    Color EnbleButton = new Color(116,255,0,225);
    Color UnenbleButton = new Color(255, 255, 255, 255);
    void Update()
    {
        if (UI_USB.activeSelf)
        {
            HaveUSB = true;
        }
        if (Input.GetButtonDown("XboxRB")&& HaveUSB)
        {
            UI_Tip1.SetActive(true);
        }
        if (UI_Tip1.activeSelf && Input.GetButton("XboxA"))
        {
            UI_Tip1.SetActive(false);
        }
    }  
}
