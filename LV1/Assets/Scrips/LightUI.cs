using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightUI : MonoBehaviour
{
    public GameObject LightGameUI_1, LightGameUI_2, LightGameUI_3, LightGameUI_4, LightGameUI_5, LightGameUI_6, LightGameUI_7, LightGameUI_8, LightGameUI_9;

    void Update()
    {
        if (CheckLight.Xnum == -1 && CheckLight.Ynum == -1)
        {
            LightGameUI_1.SetActive(true);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);

        }
        if (CheckLight.Xnum == 0 && CheckLight.Ynum == -1)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(true);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == 1 && CheckLight.Ynum == -1)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(true);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == -1 && CheckLight.Ynum == 0)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(true);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum==0&&CheckLight.Ynum == 0)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(true);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == 1 && CheckLight.Ynum == 0)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(true);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == -1 && CheckLight.Ynum == 1)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(true);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == 0 && CheckLight.Ynum == 1)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(true);
            LightGameUI_9.SetActive(false);
        }
        if (CheckLight.Xnum == 1 && CheckLight.Ynum == 1)
        {
            LightGameUI_1.SetActive(false);
            LightGameUI_2.SetActive(false);
            LightGameUI_3.SetActive(false);
            LightGameUI_4.SetActive(false);
            LightGameUI_5.SetActive(false);
            LightGameUI_6.SetActive(false);
            LightGameUI_7.SetActive(false);
            LightGameUI_8.SetActive(false);
            LightGameUI_9.SetActive(true);
        }


    }
}
