using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject _playerPoint;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("Enemy2").SendMessage("attack");
        }
    }
}
