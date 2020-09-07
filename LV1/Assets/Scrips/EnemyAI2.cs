using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{
    public WayPoint _startWayPoint;
    WayPoint _targetWayPoint;

    public GameObject _playerPoint;
    GameObject _targetPoint;
    public GameObject GG;

    float follow_ = 7;


    void Start()
    {
        _startWayPoint = GameObject.Find("WayPoint1 (1)").GetComponent<WayPoint>();

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
        if (Vector3.Distance(transform.position, _playerPoint.transform.position) >= 8f)
        {

            Debug.Log("巡邏中...");
            Vector3 v = _targetWayPoint.transform.position;
            if (Vector3.Distance(transform.position, v) < 1.5f)
            {
                _targetWayPoint = _targetWayPoint.NextWayPoint;
                Debug.Log("巡邏下一個點" + _targetWayPoint.name);
            }
            transform.LookAt(_targetWayPoint.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 10f, Space.Self);
        }
    }
    public void attack()
    {
        print("有碰到");

        if (Vector3.Distance(transform.position, _playerPoint.transform.position) < follow_)
        {

            Vector3 x = _playerPoint.transform.position;
            transform.LookAt(_playerPoint.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 10f, Space.Self);
            GG.SetActive(true);

        }
    }
}

