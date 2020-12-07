using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject[] Item, Tip;
    Color EnbleButton = new Color(116,255,0,225);
    Color UnenbleButton = new Color(255, 255, 255, 255);
    int x=-1;
    void Update()
    {
        
        if (Input.GetButtonDown("XboxRB")&& Item[x+1].activeSelf)
        {
            x += 1;
        }
        ChangeColor();
        if (Tip[x].activeSelf && Input.GetButton("XboxA"))
        {
            Item[x].GetComponent<Image>().color = UnenbleButton;
            Tip[x].SetActive(false);
            x = -1;
        }
    }
    void ChangeColor()
    {
        switch (x)
        {
            case 1:
                Item[x].GetComponent<Image>().color = EnbleButton;
                Item[x-1].GetComponent<Image>().color = UnenbleButton;
                Item[x].SetActive(true);
                Tip[x].SetActive(true);
                Tip[x-1].SetActive(false);
                break;

            case 0:
                Item[x].GetComponent<Image>().color = EnbleButton;
                Tip[x].SetActive(true);
                break;

        }
    }
}
