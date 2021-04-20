using Fungus;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class V_Follow : MonoBehaviour
{
    public Transform V;
    public float curDis;
    public float V_Speed;
    public GameObject dead_camera, BGM, soundeffect;

    void Update()
    {
        curDis -= 0.1f;
        if (curDis <= -12)
        {
            curDis = -10;
            curDis += 0.1f;
        }
        if (V_Speed == 1)
        {
            Invoke("resert", 1);
        }
        if (V_Speed == 15)
        {
            Invoke("resert_", 0.5f);
        }
    }
    public void Follow(Vector3 pos, float speed)
    {
        Vector3 position = pos - Vector3.forward * curDis;
        position.x = -1323.07f;
        V.position = Vector3.Lerp(V.position, position, V_Speed * 0.08f * Time.deltaTime);
    }
    private void resert_()
    {
        V_Speed = 11;
    }
    private void resert()
    {
        V_Speed = 15;
    }
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.tag == "a" || other.gameObject.tag == "b")
        {
            V_Speed = 1;
            //Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            dead_camera.SetActive(true);
            soundeffect.SetActive(false);
            BGM.SetActive(false);
            Invoke("loadddd", 5f);
        }
        if (other.gameObject.tag == "b")
        {
            Destroy(other.gameObject);
        }
    }
    void loadddd()
    {
        SceneManager.LoadScene("LV2");

    }
}
