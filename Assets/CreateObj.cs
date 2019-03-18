using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Ball;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Instantiate(Ball, SpawnPoint.position, SpawnPoint.rotation);

        }
        
    }
}
