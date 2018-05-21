using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rocket))]
public class RocketMovement : MonoBehaviour {

    [SerializeField] bool _movementEnabled = true;

    InputHandler inputHandler;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        inputHandler = GameObject.Find("InputHandler").GetComponent<InputHandler>();
        rb = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (_movementEnabled == true)
        {
            ProcessRocketMovement();
        }
	}

    private void ProcessRocketMovement()
    {
        /*if (inputHandler.wIsPressed == true) { rb.AddForce(Vector3.up); } // Apply forward movement.
        if (inputHandler.sIsPressed == true) { rb.AddForce(Vector3.down); }// Apply down movement.*/

        if (Input.anyKey == true) // Are there any keys being pressed?
        {
            //print(inputHandler.GetKeyCode());
            /*switch (inputHandler.GetKeyCode())// If so, which ones?
            {
                case KeyCode.W:

                    break;
                default:

                    break;
            }*/
        }
    }
}
