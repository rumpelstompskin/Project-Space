using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour {

    [SerializeField] float _rotationSpeed = 10f;
    [SerializeField] bool _addForce = true;
    [SerializeField] float _forceToAdd = 20000f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.up * (_rotationSpeed * Time.deltaTime));
        if (rb != null)
        {
            if (_addForce == true)
            {
                rb.AddForce(Vector3.left * _forceToAdd * Time.deltaTime);
            }
        }
	}
}
