﻿using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

public class V_Follow : MonoBehaviour
{
    public Transform V;
    public float curDis;
    public float V_Speed;

    void Update()
    {
        curDis -= 0.1f;
        if(curDis<=-12)
        {
            curDis = -10;
            curDis += 0.1f;
        }
        if (V_Speed == 2)
        {
            Invoke("resert", 0.8f);
        }
    }
    public void Follow(Vector3 pos,float speed)
    {
        Vector3 position = pos - Vector3.forward*curDis ;
        position.x = -1323.07f;
        V.position = Vector3.Lerp(V.position, position, V_Speed*0.08f*Time.deltaTime);
    }
    private void resert()
    {
        V_Speed = 13;
    }
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.tag=="a"||other.gameObject.tag == "b")
        {
            V_Speed = 2;
            //Destroy(other.gameObject);
        }
        if (other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("LV2");
        }
        if(other.gameObject.tag=="b")
        {
            Destroy(other.gameObject);
        }
    }
}
