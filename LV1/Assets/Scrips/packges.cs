﻿using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class packges : MonoBehaviour
{
    public GameObject UI_Start;
    public int menu;
    public Animator start;
    public Flowchart flow;
    public Flowchart fade_in;
    public GameObject Gam_fade_in, Instructions;
    int check_number = 0;
    public Animator STB;
    void FixedUpdate()
    {
        Invoke("endUIStart_1", 6.5f);
        if (STB.GetBool("min"))
        {
            Invoke("endUIStart_2", 18.017f);
            check_number = 1;
            if (check_number == 1 && Input.GetKeyDown(KeyCode.R))
            {
                Instructions.SetActive(false);
            }
        }
    }
    void endUIStart_1()
    {
        if (Input.anyKeyDown)//如果按下任意鈕
        {
            fade_in.SetBooleanVariable("淡出", true);
            flow.SetBooleanVariable("開頭",true);
            Invoke("wait", 1);
        }
    }
    void wait()
    {
        start.SetBool("start", true);
    }

    void endUIStart_2()
    {
        UI_Start.SetActive(false);

    }
}
