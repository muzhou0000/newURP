using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cam_Reset : MonoBehaviour
{
    public GameObject Cam;
    public float X_angle ;

    void Update()
    {
        //Cam.GetComponent<CinemachineFreeLook>().m_XAxis.Value = -90;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Cam.GetComponent<CinemachineFreeLook>().m_XAxis.Value = X_angle;
        }
    }
}
