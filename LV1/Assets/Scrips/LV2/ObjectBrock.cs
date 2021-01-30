using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBrock : MonoBehaviour
{
     AudioSource audioSou;
    //public AudioClip brock;
    [Tooltip("Sound effect clip to play")]
    [SerializeField]
    protected AudioClip[] soundClip;

    [Range(0, 1)]
    [Tooltip("Volume level of the sound effect")]
    [SerializeField]
    protected float volume = 1;

    private void Start()
    {
        audioSou = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "a") { 
            int rand = Random.Range(0, soundClip.Length);
            if (soundClip == null)
            {
            return;
            }
            audioSou.PlayOneShot(soundClip[rand]);
        }
    }


}
  

