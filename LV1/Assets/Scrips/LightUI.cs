using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightUI : MonoBehaviour
{
    float xAix, yAix;
    RectTransform UImove;
    private void Start()
    {
        UImove = GetComponent<RectTransform>();
    }
    void Update()
    {
        xAix = Input.GetAxisRaw("Horizontal");
        yAix = Input.GetAxisRaw("Vertical");

        Vector3 apos = UImove.position;

      
    }
}
