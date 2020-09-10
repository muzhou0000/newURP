using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Claershot_1A2B : MonoBehaviour
{
    public GameObject AB;
    public GameObject Cam;
    public GameObject MainCam;



    private void Start()
    {
        Cam.SetActive(false);
    }
    void Update()
    {
        if(AB)
        {
            Cam.GetComponent<CinemachineVirtualCamera>().Priority = 20;
            Cam.SetActive(true);
        }
        else if(AB==false)
        {
            Cam.GetComponent<CinemachineVirtualCamera>().Priority = 9;
            Cam.SetActive(false);
            MainCam.GetComponent<CinemachineVirtualCamera>().Priority = 21;
        }
    }
}
