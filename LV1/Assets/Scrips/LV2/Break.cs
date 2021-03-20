using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject BreakObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            BreakObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
