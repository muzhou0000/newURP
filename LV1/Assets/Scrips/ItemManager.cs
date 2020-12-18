using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject[] Item = new GameObject[5], Tip= new GameObject[5];
    //public GameObject Item_USB;
    Color EnbleButton = new Color(116,255,0,225);
    Color UnenbleButton = new Color(255, 255, 255, 255);
    public static int x=-1,y;
    void Update()
    {
        
        if (Input.GetButtonDown("XboxRB")&& Item[x].activeSelf)
        {
            x += 1;
            y += 1;
            ChangeColor();
        }
        if (Tip[y].activeSelf && Input.GetButton("XboxA"))
        {
            Item[x].GetComponent<Image>().color = UnenbleButton;
            Tip[y].SetActive(false);
            x = 0;
            y = 0;
        }
    }
    void ChangeColor()
    {
        switch (x)
        {
            case 2:
                Item[x].GetComponent<Image>().color = EnbleButton;
                Item[x-1].GetComponent<Image>().color = UnenbleButton;
                Item[x].SetActive(true);
                Tip[y].SetActive(true);
                Tip[y-1].SetActive(false);
                break;

            case 1:
                
                Item[x].GetComponent<Image>().color = EnbleButton;
                Tip[y].SetActive(true);
                break;

            case 0:
                x = x + 1;
                break;

        }
    }
}
