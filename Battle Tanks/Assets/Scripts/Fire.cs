using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    [SerializeField] public GameObject projectile;
    [SerializeField] public GameObject projectileSpawn;
    [SerializeField] public float projectileSpeed = 100;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float speedThisFrame = projectileSpeed * Time.deltaTime;

            GameObject bullet = Instantiate(projectile, projectileSpawn.transform.position, transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * (projectileSpeed * speedThisFrame));
        }
    }
}
