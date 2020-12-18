using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ItemManager.x += 1;

        Debug.Log("ItemManager=" + ItemManager.x);
    }

}
