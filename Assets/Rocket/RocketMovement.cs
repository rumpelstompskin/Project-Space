using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rocket))]
public class RocketMovement : MonoBehaviour {

    public float currentSpeed = 0f;
    public float maxSpeed = 2000f;

    public Vector3 currentPosition;

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
        if (Input.anyKey == true) // Are there any keys being pressed?
        {
            switch (inputHandler.GetKeyCode())// If so, which ones?
            {
                case KeyCode.W:
                    rb.AddForce(Vector3.up);
                    print("Going Up");
                    break;
                case KeyCode.S:
                    rb.AddForce(Vector3.down);
                    print("Going Down");
                    break;
                case KeyCode.A:
                    rb.AddForce(Vector3.left);
                    print("Going Left");
                    break;
                case KeyCode.D:
                    rb.AddForce(Vector3.right);
                    print("Going Right");
                    break;
                default:
                    print("Pressing an erronious key atm");
                    break;
            }
        }
    }

    void ApplyThrust(Vector3 currentPos)
    {

    }
}
