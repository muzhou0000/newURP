using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class break_destory : MonoBehaviour
{
    void Update()
    {
        if(this)
        {
            Invoke("appera", 0.1f);
            Destroy(gameObject, 1);
        }
    }
    void appera()
    {
        GetComponent<MeshCollider>().enabled = false;
    }
}
