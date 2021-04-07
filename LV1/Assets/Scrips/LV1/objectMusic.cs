using System.Collections;
using System.Collections.Generic;
using Fungus;
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
    public  GameObject high_Camera1,EGO;
    public Flowchart talk;


    private void Start()
    {
        A = true;
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
            high_Camera1.SetActive(true);
            EGO.GetComponent<MoventmentController>().enabled = false;
            Destroy(other.gameObject);
            call();
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
    public  void call()
    {
        A = false;
        Debug.Log("123");
    }

}
