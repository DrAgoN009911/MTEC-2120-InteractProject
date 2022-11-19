using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstacle : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform SpawnPoint;

    void OnCollisionEnter(Collision coll)
    { 
    if (coll.gameObject.tag == "Player")
        
    {
        Player.transform.position = SpawnPoint.transform.position;
    }
}

}

