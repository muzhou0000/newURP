using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMusic : MonoBehaviour
{
    AudioSource audioSou;
    public GameObject glassTip;
    [Tooltip("Sound effect clip to play")]
    [SerializeField]
    protected AudioClip[] soundClip;
    [SerializeField]
    protected AudioClip[] PoilClip;
    public static bool A;


    private void Start()
    {
        audioSou = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetButton("XboxA"))
        {
            glassTip.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Materials")
        {
            audioSou.volume = 0.05f;
            int rand = Random.Range(0, soundClip.Length);
            if (soundClip == null)
            {
                return;
            }
            audioSou.PlayOneShot(soundClip[rand]);
            call();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "bucket")
        {
            audioSou.volume = 0.05f;
            int rand_button = Random.Range(0, PoilClip.Length);
            if (PoilClip == null)
            {
                return;
            }
            audioSou.PlayOneShot(PoilClip[rand_button]);
            call();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Text")
        {
            glassTip.SetActive(true);
            
            audioSou.volume = 0.05f;
            int rand = Random.Range(0, soundClip.Length);
            if (soundClip == null)
            {
                return;
            }
            audioSou.PlayOneShot(soundClip[rand]);
            Destroy(other.gameObject);
        }
    }
    public static void call()
    {
        A = true;
    }

}
