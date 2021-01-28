using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Y_Cam : MonoBehaviour
{
    public Flowchart Y;
    //public Flowchart talk;
    //public GameObject A;
    //public GameObject B;
    public GameObject Cam;
    // Start is called before the first frame update
    AudioSource audio;
    public AudioClip openclip;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Y.GetBooleanVariable("Y鏡頭判定") == true && Input.GetButton("XboxY") || Y.GetBooleanVariable("Y鏡頭判定") == true && Input.GetKey(KeyCode.Y)) 
        {
            Y.SetBooleanVariable("Y鍵按下", true);
            Cam.SetActive(true);
            SounfEffect();
        }
        else
        {
            Y.SetBooleanVariable("Y鍵按下", false);
            Cam.SetActive(false);
        }
    }
    void SounfEffect()
    {
        if (Input.GetButtonDown("XboxY"))
        {
            bool a = true;
            if (a)
            {
                audio.PlayOneShot(openclip);
                a = false;
            }

        }

    }
}
