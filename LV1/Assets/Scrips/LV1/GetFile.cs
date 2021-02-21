using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFile : MonoBehaviour
{
    public bool GetFile1;
    public GameObject GetFileTip,RKey,Box;

    private void Update()
    {
        if (RKey.activeSelf && !GetFile1)
        {
            if (Input.GetButtonDown("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("132");
                GetFileTip.SetActive(true);
                RKey.SetActive(false);
                GetFile1 = true;
            }
        }
        if (GetFileTip.activeSelf == true && GetFile1)
        {
            if (Input.GetButtonUp("XboxA") || Input.GetKeyDown(KeyCode.R))
            {
                GetFileTip.SetActive(false);
                Box.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Debug.Log(123);
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
