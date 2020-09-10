using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Claershot_1A2B : MonoBehaviour
{
    public GameObject AB;
    public GameObject Cam;

    private void Start()
    {
        Cam.SetActive(false);
    }
    void Update()
    {
        if(AB==true)
        {
            Cam.GetComponent<CinemachineVirtualCamera>().Priority = 20;
            Cam.SetActive(true);
        }
    }
}
