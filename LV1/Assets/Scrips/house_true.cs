﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house_true : MonoBehaviour
{
    public GameObject hou;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            hou.SetActive(true);
        }
    }
}
