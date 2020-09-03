using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{
    public GameObject _playerPoint;

    private void OnTriggerStay(Collider other)
    {
        GameObject.Find("Enemy").SendMessage("attack");
        
    }
}
