using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public Transform target, target_origian;
    public GameObject dead, hight_camera;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            GetComponent<Transform>().LookAt(target);
            Invoke("deadOne", 2);
        }
    }
    void deadOne()
    {
        dead.SetActive(true);
        hight_camera.SetActive(false);
        GetComponent<Transform>().LookAt(target_origian);
    }

}
