using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    float time_int = 120f;
    public Text timeUI;
    public GameObject GG;
    public GameObject time_active;

    private void time()
    {
        InvokeRepeating("timecount", 1, 1);
    }

    void timecount()
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CancelInvoke("timecount");
            time_active.SetActive(false);

        }
    }
}
