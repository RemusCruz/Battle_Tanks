using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    enum State { Alive, Dead}
    State state = State.Alive;

    [SerializeField] public float movementSpeed = 10f;
    [SerializeField] float rotationSpeed = 100f;

    void Start () {
		
	}
	
	void Update ()
    {
        if (state == State.Alive)
        {
         TankInput();
        }
	}

    void TankInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.A))
        {
            RotateRight();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateLeft();
        }
    }

    private void MoveForward()
    {
        float movementThisFrame = movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, movementThisFrame);
    }

    private void MoveBackward()
    {
        float movementThisFrame = movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, -movementThisFrame);
    }

    private void RotateRight()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationThisFrame, 0);
    }

    private void RotateLeft()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(0, -rotationThisFrame, 0);
    }
}
