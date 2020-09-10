using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearShot_display : MonoBehaviour
{
    public GameObject Cam;
    public GameObject AB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AB)
        {
            Cam.SetActive(false);
        }
    }
}
