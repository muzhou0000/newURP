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
    public int[] ansArrary = new int[4];
    public InputField[] ANS;

    public Text first, second, third, four,realans;
    public Text review1, review2, review3, review4;
    int ans, a, b;
    public int preventError;
    //bool activated = false;

    bool[] flag = new bool[4];

    public Text enterText1, enterText2, enterText3, enterText4;

    public int times = 0;
    public GameObject AB,main_AB;
    public GameObject GG;
    public GameObject Cam,Player,deadPoint;
    public GameObject ABend;
    public GameObject Die;
    public GameObject Die_1;
    public GameObject Die_2;
    public Flowchart flow;
    public int index;


    private void Start()
    {

        //UnityEngine.Random rnd = new UnityEngine.Random();  //產生亂數初始值
        //for (int i = 0; i < 4; i++)
        //{
        //    randomArray[i] = UnityEngine.Random.Range(1, 10);   //亂數產生，亂數產生的範圍是1~9

        //    for (int j = 0; j < i; j++)
        //    {
        //        while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
        //        {
        //            j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
        //            randomArray[i] = UnityEngine.Random.Range(1, 10);   //重新產生，存回陣列，亂數產生的範圍是1~9
        //        }

        //    }

        //}
        randomArray[0] = 1;
        randomArray[1] = 2;
        randomArray[2] = 3;
        randomArray[3] = 4;

        ANS[index].Select();

    }

    public void Count()
    {
        times += 1;
    }
    private void Update()
    {

        Calculation();
        print(a);
        if (times <= 5 && a == 4)
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
        if (times > 5 && a < 4)
        {
            AB.SetActive(false);
            Cam.SetActive(false);
            GG.SetActive(true);
            Player.transform.position = deadPoint.transform.position;

        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            EnterAnswer();
            ccc();
        }
    }
    public void ChangeByUI()
    {
        // 編號遞增
        index++;
        // 避免跑出陣列外
        if (index == ANS.Length) index = 0;
        // 選取
        ANS[index].Select();
    }

    public void EnterAnswer()
    {
        if (preventError == 0)
        {
            switch (times)
            { 
                case 3:
                    four.text = enterText1.text + enterText2.text + enterText3.text + enterText4.text;
                    break;
                case 2:
                    third.text = enterText1.text + enterText2.text + enterText3.text + enterText4.text;
                    break;
                case 1:
                    second.text = enterText1.text + enterText2.text + enterText3.text + enterText4.text;
                    break;
                case 0:
                    first.text = enterText1.text+ enterText2.text+ enterText3.text+ enterText4.text;
                    break;
            }
        }
    }
    public void Calculation()
    {
        preventError = 0;
        //ans = int.Parse(enterText1.text);
        ////preventerror = ans / 10000;
        //ansArrary[0] = ans / 1000;
        //ansArrary[1] = (ans / 100) % 10;
        //ansArrary[2] = (ans / 10) % 10;
        //ansArrary[3] = ans % 10;

            ansArrary[0] = int.Parse(enterText1.text);
            ansArrary[1] = int.Parse(enterText2.text);
            ansArrary[2] = int.Parse(enterText3.text);
            ansArrary[3] = int.Parse(enterText4.text);
        

    }
 
    public void ccc()
    {
        if (preventError == 0)
        {
            switch (times)
            {
                case 3:
                    check();
                    review4.text = (a + "A" + b + "B");
                    break;
                case 2:
                    check();
                    review3.text = (a + "A" + b + "B");
                    break;
                case 1:
                    check();
                    review2.text = (a + "A" + b + "B");
                    break;
                case 0:
                    check();
                    review1.text = (a + "A" + b + "B");
                    break;
            }
            Count();
        }
    }
    void check()
    {
        if (preventError == 0)
        {
            a = 0;
            b = 0;
            print(ans);
            for (int i = 0; i < 4; i++)
            {
                flag[i] = false;
                if (randomArray[i] == ansArrary[i])
                {
                    a += 1;
                    flag[i] = true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (flag[i] == false)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (flag[j] == false && ansArrary[j] == randomArray[i])
                        {
                            b += 1;
                        }
                    }
                }
            }
            //activated = false;
        }
    }
}

