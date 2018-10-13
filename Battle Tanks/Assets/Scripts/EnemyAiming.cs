using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiming : MonoBehaviour {

    public GameObject target;
    public float Speed;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemyAimAt();
    }

    private void EnemyAimAt()
    {
        Vector3 targetPosition = new Vector3(
            target.transform.position.x,
            transform.position.y,
            target.transform.position.z);

        transform.LookAt(targetPosition);
    }
}

