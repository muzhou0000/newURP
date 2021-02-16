using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFile : MonoBehaviour
{
    public bool GetFile1;
    public GameObject GetFileTip,RKey,Box;

    private void Update()
    {
        if(RKey==true&&GetFile1==false)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(true);
                RKey.SetActive(false);
                GetFile1 = true;
            }
        }
        else if (GetFileTip == true && GetFile1 == true)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(false);
                Box.GetComponent<BoxCollider>().enabled = false;
            }
        }

        //if (RKey.activeSelf && (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R)))
        //{
        //    GetFileTip.SetActive(true);
        //    RKey.SetActive(false);
        //    GetFile1 = true;
        //}
        //else if (GetFileTip.activeSelf && (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R)))
        //{
        //    GetFileTip.SetActive(false);
        //    if (GetFile1)
        //    {
        //        Box.GetComponent<BoxCollider>().enabled = false;
        //    }
        //}
    }
    public void OnTriggerEnter(Collider other)
    {
        RKey.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        RKey.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
}
