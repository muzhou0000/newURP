using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class packges : MonoBehaviour
{
    public GameObject UI_Start;
    public Flowchart Introduction;
    public Animator start;
    public Animator STB;
    void FixedUpdate()
    {
        Invoke("endUIStart_1", 6.5f);
        if (STB.GetBool("min"))
        {
            Invoke("endUIStart_2", 31);
        }
    }
    void endUIStart_1()
    {
        if (Input.anyKeyDown)
        {
            Invoke("wait", 0.5f);
        }
    }
    void wait()
    {
        start.SetBool("start", true);
        Invoke("PlayIntroduction", 4.2f);

    }
    void PlayIntroduction()
    {
        Introduction.ExecuteBlock("Introduction");

    }


    void endUIStart_2()
    {
        SceneManager.LoadScene(1);
    }
}
