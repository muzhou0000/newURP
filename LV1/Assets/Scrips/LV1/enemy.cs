using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    protected GameObject[] Material;
    public Transform target;

    //void Update()
    //{
    //    if(!Material[0]&&objectMusic.A)
    //    GetComponent<Transform>().LookAt(target);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && objectMusic.A)
        {
        GetComponent<Transform>().LookAt(target);
            objectMusic.A = false;
        }
    }

}
