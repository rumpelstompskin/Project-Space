using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCamera : MonoBehaviour {

    //float _camYClamp = 89.9f;
    float _xThrow;
    float _yThrow;
    float _scrollSpeed = 50f;

    bool _camToggle = false;
    bool _camMoving = false;

    CursorLockMode mode = CursorLockMode.None;

	// Update is called once per frame
	void Update () {
        ProcessCamera();
	}

    void ProcessCamera()
    {
        //print("First step.");
        if (Input.GetKey(KeyCode.LeftAlt)/* && _camToggle*/)
        {
            //print("Second step.");
            Cursor.visible = false;
            mode = CursorLockMode.Locked;
            Cursor.lockState = mode;
            StartCoroutine(ApplyCameraRotation());
        } /*else if (!_camToggle && _camMoving == false)
        {
            StopCoroutine(ApplyCameraRotation());
        }*/
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            Cursor.visible = true;
            mode = CursorLockMode.None;
            Cursor.lockState = mode;
            _camMoving = false;
            _camToggle = !_camToggle;
            StopCoroutine(ApplyCameraRotation());
        }
    }

    IEnumerator ApplyCameraRotation()
    {
        _camToggle = !_camToggle;
        _camMoving = !_camMoving;
        //print("Third Step.");
        while (_camMoving == true)
        {
            //print("Camera Should be rotating");
            _xThrow = Input.GetAxis("Mouse X") * _scrollSpeed * Time.deltaTime;
            _yThrow = Input.GetAxis("Mouse Y") * _scrollSpeed * Time.deltaTime;

            transform.Rotate(0, _xThrow, 0, Space.World);
            transform.Rotate(-_yThrow, 0, 0, Space.Self);

            yield return new WaitForEndOfFrame();
        }

        yield return null;
    }
}
