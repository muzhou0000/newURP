using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public WayPoint _startWayPoint;
    WayPoint _targetWayPoint;

    public GameObject _playerPoint;
    GameObject _targetPoint;

    public NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _startWayPoint = GameObject.Find("WayPoint1").GetComponent<WayPoint>();
        _playerPoint = GameObject.Find("player");

        Vector3 v = _startWayPoint.transform.position;
        // < 某值，根據實際值計算
        if (Vector3.Distance(v, transform.position) < 0.5f)
        {
            _targetWayPoint = _startWayPoint.NextWayPoint;
        }
        else
        {
            _targetWayPoint = _startWayPoint;
        }
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, _playerPoint.transform.position) < 300)
        {
            Debug.Log("發現玩家...");
            if (Vector3.Distance(transform.position, _playerPoint.transform.position) < 1)
            {
                Debug.Log("攻擊動畫...");
            }
            else
            {
                agent.SetDestination(_playerPoint.transform.position);
            }

        }
        else
        {
            Debug.Log("巡邏中...");
            Vector3 v = _targetWayPoint.transform.position;
            if (Vector3.Distance(transform.position, v) < 0.5f)
            {
                _targetWayPoint = _targetWayPoint.NextWayPoint;
                Debug.Log("巡邏下一個點" + _targetWayPoint.name);
            }
            transform.LookAt(_targetWayPoint.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 30f, Space.Self);
        }
    }
}
