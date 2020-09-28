using Fungus;
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
    public GameObject Gam_fade_in;


    void FixedUpdate()
    {
        Invoke("endUIStart_1", 6.5f);

    }
    void endUIStart_1()
    {
        if (Input.anyKeyDown)//如果按下任意鈕
        {
            fade_in.SetBooleanVariable("淡出", true);
            flow.SetBooleanVariable("開頭",true);
            Invoke("wait", 1);
            Invoke("wait_1", 0.5f);
            //等17秒後執行下面那個程式
            Invoke("endUIStart_2", 41);
        }
    }

    void wait()
    {
        start.SetBool("start", true);
    }
    void Fadeout()
    {
        fade_in.SetBooleanVariable("淡出", true);
    }

    void endUIStart_2()
    {

        UI_Start.SetActive(false);

    }
}
