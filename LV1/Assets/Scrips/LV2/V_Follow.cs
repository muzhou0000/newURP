using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

public class V_Follow : MonoBehaviour
{
    public Transform V;
    public float curDis;
    public float V_Speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curDis -= 0.1f;
        if(curDis<=-12)
        {
            curDis = -10;
            curDis += 0.1f;
        }
        if (V_Speed == 8)
        {
            Invoke("resert", 1);
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
        if(other.gameObject.tag=="a")
        {
            V_Speed = 8;
            Destroy(other.gameObject);


        }
        if (other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("LV2");
        }
    }
}
