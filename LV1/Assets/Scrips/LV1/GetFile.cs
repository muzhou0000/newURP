using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GetFile : MonoBehaviour
{
    public bool GetFile1;
    public GameObject GetFileTip,RKey,Box,Door,DoorLight,Timeline_A,display,file;
    public Flowchart Talk;

    private void Update()
    {
        if (RKey.activeSelf && !GetFile1)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(true);
                file.SetActive(true);
                RKey.SetActive(false);
                GetFile1 = true;
                Timeline_A .SetActive(true);
                display.SetActive(false);
                Talk.SetBooleanVariable("對話中",true);
            }
        }
        else if (GetFileTip.activeSelf == true && GetFile1)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(false);
                Box.GetComponent<BoxCollider>().enabled = false;
                Door.GetComponent<BoxCollider>().enabled = true;
                DoorLight.SetActive(true);
                Timeline_A.SetActive(false);
                Talk.SetBooleanVariable("對話中", false);
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
