using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diecheck : MonoBehaviour
{
    public GameObject Player;
    public Transform ware_dead;
    public Transform roof_dead;
    public GameObject GG;

    //void DeadInWare()
    //{
    //    Player.transform.position = ware_dead.position;
    //    Player.transform.rotation = ware_dead.rotation;
    //}

    void DeadInRoof()
    {
        Player.transform.position = roof_dead.position;
        Player.transform.rotation = roof_dead.rotation;

    }
}
