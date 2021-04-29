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
    public GameObject EGO, high_Camera1, high_Camera2, high_Camera3;
    public Flowchart talk;
    public GameObject dead;
    public Vector3 roof_dead;



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
        //if (other.gameObject.tag == "Materials")
        //{
        //    audioSou.volume = 0.05f;
        //    int rand = Random.Range(0, soundClip.Length);
        //    if (soundClip == null)
        //    {
        //        return;
        //    }
        //    audioSou.PlayOneShot(soundClip[rand]);
        //    high_Camera1.SetActive(true);
        //    Move();
        //    high_Camera1.SetActive(false);
        //    Destroy(other.gameObject);
        //}
        //if (other.gameObject.tag == "Materials2")
        //{
        //    audioSou.volume = 0.05f;
        //    int rand = Random.Range(0, soundClip.Length);
        //    if (soundClip == null)
        //    {
        //        return;
        //    }
        //    audioSou.PlayOneShot(soundClip[rand]);
        //    high_Camera2.SetActive(true);
        //    Move();
        //    high_Camera2.SetActive(false);
        //    Destroy(other.gameObject);
        //}
        //if (other.gameObject.tag == "bucket")
        //{
        //    audioSou.volume = 0.05f;
        //    int rand_button = Random.Range(0, PoilClip.Length);
        //    if (PoilClip == null)
        //    {
        //        return;
        //    }
        //    audioSou.PlayOneShot(PoilClip[rand_button]);
        //    high_Camera3.SetActive(true);
        //    Move();
        //    high_Camera3.SetActive(false);
        //    Destroy(other.gameObject);
        //}
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
    //private void  Move()
    //{
    //    dead.SetActive(true);
    //    EGO.GetComponent<MoventmentController>().enabled = false;
    //    EGO.transform.position = roof_dead;
    //    EGO.GetComponent<MoventmentController>().enabled = true;
    //}


}
