using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFile : MonoBehaviour
{
    public GameObject GetFileTip,RKey;
    public void OnTriggerEnter(Collider other)
    {
        RKey.SetActive(true);
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (RKey.activeSelf && (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R)))
        {
            RKey.SetActive(false);
            GetFileTip.SetActive(true);
        }else if(GetFileTip.activeSelf && (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R)))
        {
            GetFileTip.SetActive(false);
        }
    }
}
