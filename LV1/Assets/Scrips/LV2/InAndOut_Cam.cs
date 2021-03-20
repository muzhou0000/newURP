using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAndOut_Cam : MonoBehaviour
{
    public float tempTime;
    private bool isInView;

    private void Update()
    {
        //OnBecameInvisible();
        if (isInView)
        {
            //Debug.Log(this.name.ToString() + "這個物體出現在螢幕裡面了");
            if (tempTime < 1)
            {
                tempTime = tempTime + Time.deltaTime;
            }
            if (this.GetComponent<Renderer>().material.color.a <= 1)
            {
                this.GetComponent<Renderer>().material.color = new Color(
                this.GetComponent<Renderer>().material.color.r,
                this.GetComponent<Renderer>().material.color.g,
                this.GetComponent<Renderer>().material.color.b,

                gameObject.GetComponent<Renderer>().material.color.a + tempTime/20);
            }
        }
    }
    private void OnBecameVisible()
    {
        isInView = true;
    }

    private void OnBecameInvisible()
    {
        isInView = false;
    }

}



