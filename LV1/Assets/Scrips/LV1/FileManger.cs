using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManger : MonoBehaviour
{
    public GameObject File;

    private void Update()
    {
        if(Input.GetButtonDown("XboxLB"))
        {
            File.SetActive(true);
        }
        else if (Input.GetButtonUp("XboxA")){
            File.SetActive(false);

        }
    }
}
