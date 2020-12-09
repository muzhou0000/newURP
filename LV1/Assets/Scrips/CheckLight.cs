﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CheckLight : MonoBehaviour
{

    public Light check1, check2, check3, check4, check5, check6, check7, check8, check9;
    public GameObject countdown;
    public GameObject GG;
    public GameObject Player;
    public GameObject Cam;
    public GameObject AB;
    public GameObject Flash;
    public GameObject Cam_1;
    public GameObject Emeny;
    public float xAix, yAix;
    int Xnum, Ynum;

    void Start()
    {
        check1.enabled = false;
        check2.enabled = false;
        check3.enabled = false;
        check4.enabled = false;
        check5.enabled = false;
        check6.enabled = false;
        check7.enabled = false;
        check8.enabled = false;
        check9.enabled = false;
    }

    void Update()
    {
        inputNum();
        xAix = Input.GetAxis("Horizontal");
        yAix = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.Keypad1)||(xAix==-1&&yAix==-1 && Input.GetButtonDown("XboxA"))) {

        check1.enabled = !check1.enabled;
        check4.enabled = !check4.enabled;
        check2.enabled = !check2.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)||(xAix == 0 && yAix == -1 && Input.GetButtonDown("XboxA")))
        {
            check1.enabled = !check1.enabled;
            check2.enabled = !check2.enabled;
            check3.enabled = !check3.enabled;
            check5.enabled = !check5.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || (xAix == 1 && yAix == -1 && Input.GetButtonDown("XboxA")))
        {
            check3.enabled = !check3.enabled;
            check6.enabled = !check6.enabled;
            check2.enabled = !check2.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || (xAix == -1 && yAix == 0 && Input.GetButtonDown("XboxA")))
        {
            check7.enabled = !check7.enabled;
            check5.enabled = !check5.enabled;
            check1.enabled = !check1.enabled;
            check4.enabled = !check4.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) || (xAix == 0 && yAix == 0&&Input.GetButtonDown("XboxA")))
        {
            check5.enabled = !check5.enabled;
            check6.enabled = !check6.enabled;
            check8.enabled = !check8.enabled;
            check4.enabled = !check4.enabled;
            check2.enabled = !check2.enabled;

        }
        if (Input.GetKeyDown(KeyCode.Keypad6) || (xAix == 1 && yAix == 0 && Input.GetButtonDown("XboxA")))
        {
            check6.enabled = !check6.enabled;
            check3.enabled = !check3.enabled;
            check5.enabled = !check5.enabled;
            check9.enabled = !check9.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad7) || (xAix ==-1 && yAix == 1 && Input.GetButtonDown("XboxA")))
        {
            check7.enabled = !check7.enabled;
            check4.enabled = !check4.enabled;
            check8.enabled = !check8.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) || (xAix == 0 && yAix == 1 && Input.GetButtonDown("XboxA")))
        {
            check8.enabled = !check8.enabled;
            check5.enabled = !check5.enabled;
            check7.enabled = !check7.enabled;
            check9.enabled = !check9.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) || (xAix == 1 && yAix == 1 && Input.GetButtonDown("XboxA")))
        {
            check9.enabled = !check9.enabled;
            check6.enabled = !check6.enabled;
            check8.enabled = !check8.enabled;
        }

        if (check1.enabled && check2.enabled && check3.enabled && check4.enabled && check5.enabled && check6.enabled && check7.enabled && check8.enabled && check9.enabled)
        {
            //countdown.SetActive(true);
            //GameObject.Find("countdown").SendMessage("time");
            Player.SetActive(true);
            Cam.SetActive(false);
            Flash.SetActive(true);
            Cam_1.SetActive(true);
            Emeny.SetActive(false);
            //AB.SetActive(true);
        }
       
        if (Input.GetKeyDown(KeyCode.R)||Input.GetButtonDown("XboxB"))
        {
            check1.enabled = false;
            check2.enabled = false;
            check3.enabled = false;
            check4.enabled = false;
            check5.enabled = false;
            check6.enabled = false;
            check7.enabled = false;
            check8.enabled = false;
            check9.enabled = false;
        }
    }
    void inputNum()
    {
        Debug.Log("X="+Xnum);
        Debug.Log("Y="+Ynum);

    }
}
