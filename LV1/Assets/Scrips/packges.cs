﻿using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class packges : MonoBehaviour
{
    public GameObject UI_Start,BBC;
    public int menu;
    public Animator start;
    void Update()
    {
        if (Input.anyKeyDown)//如果按下任意鈕
        {
            start.SetBool("start", true);
            //等17秒後執行下面那個程式
            Invoke("endUIStart", 15.267f);
        }
    }
    void endUIStart()
    {

        UI_Start.SetActive(false);

    }
}
