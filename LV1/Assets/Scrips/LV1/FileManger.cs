using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class FileManger : MonoBehaviour
{
    public GameObject File,TxT_File;
    public Animator OpenAni;
    public AudioSource Open;
    bool A;
    int B;

    private void Update()
    {
        if(Input.GetButtonDown("XboxLB") &&!A || Input.GetKeyDown(KeyCode.F)&&!A)
        {
            Open.Play();
            File.SetActive(true);
            OpenAni.SetBool("ani", true);
            OpenFile();
            CheckLight.intnum();
            A = true;
        }
        // if (A&&Input.GetButtonUp("XboxLB") ||A&&Input.GetKeyDown(KeyCode.Escape)){
        //    File.SetActive(false);
        //    OpenAni.SetBool("ani", false);
        //    A = false;
        //    Debug.Log(A);
        //}
        if (Input.GetButtonDown("XboxA") && File.activeSelf&&B==0)
        {
            TxT_File.SetActive(true);
            B += 1;
            if (Input.GetButtonDown("XboxA") && TxT_File.activeSelf&&B>=1)
            {

                TxT_File.SetActive(false);
            }
        }
    }
    void OpenFile()
    {
        print("2");

        if (Input.GetButtonUp("XboxA")&& TxT_File.activeSelf)
        {
        }
        
    }
}
