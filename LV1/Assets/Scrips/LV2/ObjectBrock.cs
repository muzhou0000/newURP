using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBrock : MonoBehaviour
{
    private AudioSource audioSou;
    public AudioClip brock;

    private void Start()
    {
        audioSou = GetComponent<AudioSource>();
    }
    public static void soundEffect()
    {

        Debug.Log("213");
        //audioSou.Play();
    }
}
