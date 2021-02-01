using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class footage : MonoBehaviour
{
    [SerializeField]
    AudioClip[] clips;
    AudioSource audiosou;

    private void Awake()
    {
        audiosou = GetComponent<AudioSource>();
    }
    void Step()
    {
        Debug.Log("3");
        AudioClip clip = GetRandomClip();
        audiosou.PlayOneShot(clip);
    }
    AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
