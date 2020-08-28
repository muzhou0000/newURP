using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class packges : MonoBehaviour
{
    public GameObject UI_Start;
    public int menu;
    public Animator STB_ani;
    void Update()
    {
        if (Input.anyKeyDown)//如果按下任意鈕
        {
            STB_ani.SetBool("1", true);
            //等17秒後執行下面那個程式
            Invoke("endUIStart", 17);
        }
    }
    void endUIStart()
    {

        UI_Start.SetActive(false);
    }
}
