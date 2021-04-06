using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class footage : MonoBehaviour
{
    [SerializeField]
    protected AudioClip[] clips;
    AudioSource audiosou;

    private void Awake()
    {
        audiosou = GetComponent<AudioSource>();
    }
    void Step()
    {
        audiosou.volume = 0.152f;
        int rand = Random.Range(0, clips.Length);
        if (clips == null)
        {
            return;
        }
        audiosou.PlayOneShot(clips[rand]);
    }
    //AudioClip GetRandomClip()
    //{

    //    return clips[UnityEngine.Random.Range(0, clips.Length)];
    //}
}
