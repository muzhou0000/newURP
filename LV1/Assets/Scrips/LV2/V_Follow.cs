using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Follow : MonoBehaviour
{
    public Transform V;
    public float curDis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void Follow(Vector3 pos,float speed)
    {
        Vector3 position = pos - Vector3.forward * curDis;
        position.x = -1323.07f;
        V.position = Vector3.Lerp(V.position, position, 1.5f*Time.deltaTime);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="a")
        {
            Destroy(other.gameObject);
        }
    }
}
