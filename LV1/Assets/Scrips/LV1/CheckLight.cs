using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CheckLight : MonoBehaviour
{

    public Light check1, check2, check3, check4, check5, check6, check7, check8, check9;
    public GameObject countdown,LightUI;
    public GameObject GG;
    public GameObject Player;
    public GameObject Cam;
    public GameObject AB;
    public GameObject Flash;
    public GameObject Cam_1;
    public GameObject Emeny;
    public float xAix, yAix;
    public static int Xnum, Ynum;
    bool addx,addy;
    public AudioSource audioSource;

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
        audioSource.GetComponent<AudioSource>();
    }

    void Update()
    {
        intnum();
        xAix = Input.GetAxisRaw("Horizontal");
        yAix = Input.GetAxisRaw("Vertical");
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
            LightUI.SetActive(false);   bb
        }
        if (!Player.activeSelf) { 
        LightCheck();
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
    void intnum()
    {

        if (xAix > 0 && addx)
        {
            Xnum++;
            addx = false;
            if (Xnum > 1)
            {
                Xnum = 1;
            }
        }
        else if (xAix == 0 && !addx)
        {
            addx = true;
        }
        else if (xAix < 0 && addx)
        {
            Xnum--;
            addx = false;
            if (Xnum < 1)
            {
                Xnum = -1;
            }
        }
        if (yAix > 0 && addy)
        {
            Ynum++;
            addy = false;
            if (Ynum > 1)
            {
                Ynum = 1;
            }
        }
        else if (yAix == 0 && !addy)
        {
            addy = true;
        }
        else if (yAix < 0 && addy)
        {
            Ynum--;
            addy = false;
            if (Ynum < 1)
            {
                Ynum = -1;
            }
        }
    }
    public void LightCheck()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || (Xnum == -1 && Ynum == -1 && Input.GetButtonDown("XboxA")))
        {

            check1.enabled = !check1.enabled;
            check4.enabled = !check4.enabled;
            check2.enabled = !check2.enabled;
            audioSource.Play();
            
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || (Xnum == 0 && Ynum == -1 && Input.GetButtonDown("XboxA")))
        {
            check1.enabled = !check1.enabled;
            check2.enabled = !check2.enabled;
            check3.enabled = !check3.enabled;
            check5.enabled = !check5.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || (Xnum == 1 && Ynum == -1 && Input.GetButtonDown("XboxA")))
        {
            check3.enabled = !check3.enabled;
            check6.enabled = !check6.enabled;
            check2.enabled = !check2.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || (Xnum == -1 && Ynum == 0 && Input.GetButtonDown("XboxA")))
        {
            check7.enabled = !check7.enabled;
            check5.enabled = !check5.enabled;
            check1.enabled = !check1.enabled;
            check4.enabled = !check4.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad5) || (Xnum == 0 && Ynum == 0 && Input.GetButtonDown("XboxA")))
        {
            check5.enabled = !check5.enabled;
            check6.enabled = !check6.enabled;
            check8.enabled = !check8.enabled;
            check4.enabled = !check4.enabled;
            check2.enabled = !check2.enabled;
            audioSource.Play();


        }
        if (Input.GetKeyDown(KeyCode.Keypad6) || (Xnum == 1 && Ynum == 0 && Input.GetButtonDown("XboxA")))
        {
            check6.enabled = !check6.enabled;
            check3.enabled = !check3.enabled;
            check5.enabled = !check5.enabled;
            check9.enabled = !check9.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad7) || (Xnum == -1 && Ynum == 1 && Input.GetButtonDown("XboxA")))
        {
            check7.enabled = !check7.enabled;
            check4.enabled = !check4.enabled;
            check8.enabled = !check8.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad8) || (Xnum == 0 && Ynum == 1 && Input.GetButtonDown("XboxA")))
        {
            check8.enabled = !check8.enabled;
            check5.enabled = !check5.enabled;
            check7.enabled = !check7.enabled;
            check9.enabled = !check9.enabled;
            audioSource.Play();

        }
        if (Input.GetKeyDown(KeyCode.Keypad9) || (Xnum == 1 && Ynum == 1 && Input.GetButtonDown("XboxA")))
        {
            check9.enabled = !check9.enabled;
            check6.enabled = !check6.enabled;
            check8.enabled = !check8.enabled;
            audioSource.Play();

        }
    }
}
