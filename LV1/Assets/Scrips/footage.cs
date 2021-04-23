using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class footage : MonoBehaviour
{
    [SerializeField]
    protected AudioClip[] clips;
    [SerializeField]
    protected AudioClip[] ladder_clips;

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
    void ladder()
    {
        audiosou.volume = 0.152f;
        int ladder_rand = Random.Range(0, ladder_clips.Length);
        if (ladder_clips == null)
        {
            return;
        }
        audiosou.PlayOneShot(ladder_clips[ladder_rand]);
    }
    //AudioClip GetRandomClip()
    //{

    //    return clips[UnityEngine.Random.Range(0, clips.Length)];
    //}
}
