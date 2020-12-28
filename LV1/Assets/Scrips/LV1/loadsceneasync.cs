using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsceneasync : MonoBehaviour
{
    AsyncOperation async;

    private void Start()
    {
        async = SceneManager.LoadSceneAsync("MGR");
        async.allowSceneActivation = false;
    }
    private void Update()
    {
        Debug.Log(async.progress);

        if (Input.GetKeyDown(KeyCode.B))
        {
            async.allowSceneActivation = true;
        }
    }
}
