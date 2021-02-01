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
  

