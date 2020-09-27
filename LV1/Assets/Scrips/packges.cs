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
    void FixedUpdate()
    {
        Invoke("endUIStart_1", 6.5f);

    }
    void endUIStart_1()
    {
        if (Input.anyKeyDown)//如果按下任意鈕
        {
            start.SetBool("start", true);
            //等17秒後執行下面那個程式
            Invoke("endUIStart_2", 19);
        }
    }

    void endUIStart_2()
    {

        UI_Start.SetActive(false);

    }
}
