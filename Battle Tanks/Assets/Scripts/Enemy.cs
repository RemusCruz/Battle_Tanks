using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform Tank;
    [SerializeField] int moveSpeed = 4;
    [SerializeField] int maxDistance = 10;
    [SerializeField] int minDistance = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }

    private void EnemyMovement()
    {
        transform.LookAt(Tank);

        if (Vector3.Distance(transform.position, Tank.position) >= minDistance)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            
            if (Vector3.Distance(transform.position, Tank.position) <= maxDistance)
            {
                //Here Call any function U want Like Shoot at here or something
            }
        }
    }
}

