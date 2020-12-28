using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    float time_int = 30f;
    public Text timeUI;
    public GameObject GG;
    public GameObject time_active;
    public Flowchart opendoor;
    string MyFloatName = "RE";



    private void Update()
    {
        time_int -= Time.deltaTime;
        timeUI.text = time_int + "秒";
        if (time_int <= 0)
        {
            CancelInvoke("timecount");
            GG.SetActive(true);
            time_active.SetActive(false);
        }
    }
    private void time()
    {
        InvokeRepeating("timecount", 1, 1);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CancelInvoke("timecount");
            time_active.SetActive(false);

        }
    }
}
