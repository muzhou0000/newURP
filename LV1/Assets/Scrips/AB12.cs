using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class AB12 : MonoBehaviour
{
    public int[] randomArray = new int[4];
    public Text[] ansArrary = new Text[4];

    public Text first, second, third, four,realans;
    public Text review1, review2, review3, review4;
    int  A, B;
    int a,b,c,d = 0;


    public int preventError;

    bool[] flag = new bool[4];

    public int times = 0;
    public GameObject AB,main_AB;
    public GameObject GG;
    public GameObject Cam,Player,deadPoint;
    public GameObject ABend;
    public GameObject Die;
    public GameObject Die_1;
    public GameObject Die_2;
    public Flowchart flow;

    float xAix, yAix;
    int Xnum;
    bool addx, addy;




    private void Start()
    {
        randomArray[0] = 1;
        randomArray[1] = 2;
        randomArray[2] = 3;
        randomArray[3] = 4;
    }

    public void Count()
    {
        times += 1;
    }
    private void Update()
    {
        xAix = Input.GetAxisRaw("Horizontal");
        yAix = Input.GetAxisRaw("Vertical");
        MoveAndAdd();

        if (times <= 5 && A == 4)
        {
            AB.SetActive(false);
            Cam.SetActive(false);
            ABend.SetActive(true);
            Die.SetActive(false);
            flow.SetBooleanVariable("對話中", false);
            Die_1.SetActive(true);
            Die_2.SetActive(true);

            if (Input.anyKeyDown)
            {
                ABend.SetActive(false);
                main_AB.SetActive(false);
                times += 5;
            }
        }
        if (times > 5 && A < 4)
        {
            AB.SetActive(false);
            Cam.SetActive(false);
            GG.SetActive(true);
            Player.transform.position = deadPoint.transform.position;

        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)||Input.GetButtonDown("XboxA")) 
        {
            EnterAnswer();
            ccc();
        }
    }
   
    void MoveAndAdd()
    {
        if (xAix > 0 && addx)
        {
            Xnum++;
            addx = false;
            if (Xnum > 3)
            {

                Xnum = 0;

            }

        }
        else if (xAix == 0 && !addx) addx = true;
        else if (xAix < 0 && addx)
        {
            Xnum--;
            addx = false;
            if (Xnum <= 0)
            {

                Xnum = 0;

            }
        }

        //分割線

        if (yAix > 0 && addy && Xnum == 0)
        {
            a++;
            if (a > 9)
            {
                a = 0;
            }
            ansArrary[0].text = "" + a;
            addy = false;

        }
        else if (yAix == 0 && !addy && Xnum == 0) addy = true;
        else if (yAix < 0 && addy && Xnum == 0)
        {
            a--;
            if (a <= 0)
            {
                a = 9;
            }
            ansArrary[0].text = "" + a;
            addy = false;

        }

        //分割線

        if (yAix > 0 && addy && Xnum == 1)
        {
            b++;
            if (b > 9)
            {
                b = 0;
            }
            ansArrary[1].text = "" + b;
            addy = false;

        }
        else if (yAix == 0 && !addy && Xnum == 1) addy = true;
        else if (yAix < 0 && addy && Xnum == 1)
        {
            b--;
            if (b <= 0)
            {
                b = 9;
            }
            ansArrary[1].text = "" + b;
            addy = false;
        }
        //分割線

        if (yAix > 0 && addy && Xnum == 2)
        {
            c++;
            if (c > 9)
            {
                c = 0;
            }
            ansArrary[2].text = "" + c;
            addy = false;

        }
        else if (yAix == 0 && !addy && Xnum == 2) addy = true;
        else if (yAix < 0 && addy && Xnum == 2)
        {
            c--;
            if (c <= 0)
            {
                c = 9;
            }
            ansArrary[2].text = "" + c;
            addy = false;
        }
        //分割線

        if (yAix > 0 && addy && Xnum == 3)
        {
            d++;
            if (d > 9)
            {
                d = 0;
            }
            ansArrary[3].text = "" + d;
            addy = false;

        }
        else if (yAix == 0 && !addy && Xnum == 3) addy = true;
        else if (yAix < 0 && addy && Xnum == 3)
        {
            d--;
            if (d <= 0)
            {
                d = 9;
            }
            ansArrary[3].text = "" + d;
            addy = false;
        }
    }
    public void EnterAnswer()
    {
        if (preventError == 0)
        {
            switch (times)
            { 
                case 3:
                    four.text = "" + a + "" + b + "" + c + "" + d;
                    break;
                case 2:
                    third.text = "" + a + "" + b + "" + c + "" + d;
                    break;
                case 1:
                    second.text = "" + a + "" + b + "" + c + "" + d;
                    break;
                case 0:
                    first.text = "" + a + "" + b + "" + c + "" + d;
                    break;
            }
        }
    }

    public void ccc()
    {
        if (preventError == 0)
        {
            switch (times)
            {
                case 3:
                    check();
                    review4.text = (A + "A" + B + "B");
                    break;
                case 2:
                    check();
                    review3.text = (A + "A" + B + "B");
                    break;
                case 1:
                    check();
                    review2.text = (A + "A" + B + "B");
                    break;
                case 0:
                    check();
                    review1.text = (A + "A" + B + "B");
                    break;
            }
            Count();
        }
    }
    void check()
    {
        if (preventError == 0)
        {
            A = 0;
            B = 0;
            for (int i = 0; i < 4; i++)
            {
                flag[i] = false;
                if (randomArray[i] == int.Parse(ansArrary[i].text))
                {
                    A += 1;
                    flag[i] = true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (flag[i] == false)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (flag[j] == false && int.Parse(ansArrary[j].text) == randomArray[i])
                        {
                            B += 1;
                        }
                    }
                }
            }
        }
    }
}

