using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class FileManger : MonoBehaviour
{
    public GameObject File;
    public Animator OpenAni;
    public AudioSource Open;

    private void Update()
    {
        if(Input.GetButtonDown("XboxLB")||Input.GetKeyDown(KeyCode.F))
        {
            Open.Play();
            File.SetActive(true);
            OpenAni.SetBool("ani", true);
        }
        else if (Input.GetButtonUp("XboxA")||Input.GetKeyDown(KeyCode.Escape)){
            File.SetActive(false);
            OpenAni.SetBool("ani", false);

        }
    }
}
