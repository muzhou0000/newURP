using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Y_Cam : MonoBehaviour
{
    public Flowchart Y;
    public Flowchart talk;
    public GameObject A;
    public GameObject B;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Y.GetBooleanVariable("Y鏡頭判定") == true && Input.GetButton("XboxY"))
        {
            Y.SetBooleanVariable("Y鍵按下", true);
            Cam.SetActive(true);
        }
        else
        {
            Y.SetBooleanVariable("Y鍵按下", false);
            Cam.SetActive(false);
        }
    }
}
