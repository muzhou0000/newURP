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
    [SerializeField]
    protected AudioClip[] EmenyStepClip;

    AudioSource audiosou;

    private void Awake()
    {
        audiosou = GetComponent<AudioSource>();
    }
    void Step()
    {
        audiosou.volume = 0.4f;
        int rand = Random.Range(0, clips.Length);
        if (clips == null)
        {
            return;
        }
        audiosou.PlayOneShot(clips[rand]);
    }
    void ladder()
    {
        audiosou.volume = 0.5f;
        int ladder_rand = Random.Range(0, ladder_clips.Length);
        if (ladder_clips == null)
        {
            return;
        }
        audiosou.PlayOneShot(ladder_clips[ladder_rand]);
    }
    void EmenyStep()
    {
        audiosou.volume = 0.3f;
        int Emeny_rand = Random.Range(0, EmenyStepClip.Length);
        if (EmenyStepClip == null)
        {
            return;
        }
        audiosou.PlayOneShot(EmenyStepClip[Emeny_rand]);
    }
    //AudioClip GetRandomClip()
    //{

    //    return clips[UnityEngine.Random.Range(0, clips.Length)];
    //}
}
