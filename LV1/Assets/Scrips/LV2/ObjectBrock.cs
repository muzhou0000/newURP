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
    [SerializeField]
    protected AudioClip[] PoilClip;



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
        if (other.gameObject.tag == "b")
        {
            int rand_button = Random.Range(0, PoilClip.Length);
            if (PoilClip == null)
            {
                return;
            }
            audioSou.PlayOneShot(PoilClip[rand_button]);
        }
    }
}
  

