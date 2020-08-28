using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;    //使用UnityEngine.AI



public class Nav : MonoBehaviour
{
    public NavMeshAgent agent;    //宣告NavMeshAgent
    public GameObject target_obj;    //目標物件

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();        //接收NavMeshAgent


    }

    // Update is called once per frame
    void Update()
    {
        followPlayer();
    }
    //要試試看的方法1
    //靠近的時候用trigger打開Update
    void followPlayer()
    {
        agent.SetDestination(target_obj.transform.position);    //讓紅方塊往目標物的座標移動

    }

}
