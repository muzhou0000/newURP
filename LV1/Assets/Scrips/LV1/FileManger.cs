using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class FileManger : MonoBehaviour
{
    public GameObject File,TxT_File;
    public Animator OpenAni;
    public AudioSource Open;
    int B, C;

    private void Update()
    {
        count();
        if (Input.GetButtonDown("XboxLB") &&B==1 || Input.GetKeyDown(KeyCode.F)&& B == 1)
        {
            Open.Play();
            File.SetActive(true);
            OpenAni.SetBool("ani", true);
            CheckLight.intnum();
        }
        if (B>1 && Input.GetButtonUp("XboxLB") || B > 1 && Input.GetKeyDown(KeyCode.Escape))
        {
            File.SetActive(false);
            OpenAni.SetBool("ani", false);
            if (B > 1)
            {
                B = 0;
            }
        }
        if (Input.GetButtonDown("XboxA") && File.activeSelf&&C==1)
        {  
            TxT_File.SetActive(true);
            
        }
        if (Input.GetButtonDown("XboxA") && TxT_File.activeSelf && C > 1 || !File.activeSelf)
        {
            TxT_File.SetActive(false);
            if (C > 1)
            {
                C = 0;
            }

        }
    }
void count()
    {
        if (Input.GetButtonDown("XboxLB"))
        {
            B += 1;
        }
        if (Input.GetButtonDown("XboxA"))
        {
            C += 1;
        }
        if (B ==0)
        {
            C = 0;
        }
    }
}
