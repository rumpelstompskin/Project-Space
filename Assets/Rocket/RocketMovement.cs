using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rocket))]
public class RocketMovement : MonoBehaviour {

    [SerializeField] float _rocketThrust = 1000f;
    [SerializeField] float _stabilityThrust = 500f;
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
                    rb.AddTorque(transform.right *_stabilityThrust * Time.deltaTime);
                    //rb.AddForce(Vector3.up);
                    //print("Going Up");
                    break;
                case KeyCode.S:
                    rb.AddTorque(-transform.right * _stabilityThrust * Time.deltaTime);
                    //rb.AddForce(Vector3.down);
                    //print("Going Down");
                    break;
                case KeyCode.Q:
                    rb.AddTorque(transform.up * _stabilityThrust * Time.deltaTime);
                    //rb.AddForce(Vector3.left);
                    //print("Going Left");
                    break;
                case KeyCode.E:
                    rb.AddTorque(-transform.up * _stabilityThrust * Time.deltaTime);
                    //rb.AddForce(Vector3.right);
                    //print("Going Right");
                    break;
                case KeyCode.A:
                    rb.AddTorque(transform.forward * _stabilityThrust * Time.deltaTime);
                    break;
                case KeyCode.D:
                    rb.AddTorque(-transform.forward * _stabilityThrust * Time.deltaTime);
                    break;
                case KeyCode.Space:
                    rb.AddRelativeForce(Vector3.up * _rocketThrust * Time.deltaTime);
                    break;
                case KeyCode.LeftControl:
                    rb.AddRelativeForce(-Vector3.up* _rocketThrust * Time.deltaTime);
                    break;
                default:
                    print("Pressing an erronious key atm");
                    break;
            }
        }
    }
}
