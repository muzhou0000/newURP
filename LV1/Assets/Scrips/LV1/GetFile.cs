using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFile : MonoBehaviour
{
    public bool GetFile1;
    public GameObject GetFileTip,RKey,Box,Door;

    private void Update()
    {
        if (RKey.activeSelf && !GetFile1)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(true);
                RKey.SetActive(false);
                GetFile1 = true;
            }
        }
        else if (GetFileTip.activeSelf == true && GetFile1)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(false);
                Box.GetComponent<BoxCollider>().enabled = false;
                Door.GetComponent<BoxCollider>().enabled = true;
            }
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            RKey.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") { 
            RKey.SetActive(false);
        }

    }
}
