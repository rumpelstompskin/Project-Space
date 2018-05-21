using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    public bool wIsPressed = false;
    public bool aIsPressed = false;
    public bool sIsPressed = false;
    public bool dIsPressed = false;
    public bool leftCtrlIsPressed = false;
    public bool spaceIsPressed = false;

    public List<KeyCode> keys = new List<KeyCode>();


    // Use this for initialization
    void Start() {
        keys.Add(KeyCode.W);
        keys.Add(KeyCode.A);
        keys.Add(KeyCode.S);
        keys.Add(KeyCode.D);
        keys.Add(KeyCode.LeftControl);
        keys.Add(KeyCode.Space);
    }

    // Update is called once per frame
    void Update() {
        //ProcessKeyboard();
        if (Input.anyKey)
        {
            foreach (KeyCode inputs in keys)
            {
                /*if (Input.GetKeyDown(KeyCode.W) == inputs)
                {
                    print("Kewl");
                }*/
            }
        }
    }

    public void CheckRotationKeys()
    {
        //key_move = { KeyCode.W : (1,0,0), }
    }
    /*
    void ProcessKeyboard()
    {
        if (Input.GetKey(KeyCode.W)) { wIsPressed = true; }
        if (Input.GetKey(KeyCode.A)) { aIsPressed = true; }
        if (Input.GetKey(KeyCode.S)) { sIsPressed = true; }
        if (Input.GetKey(KeyCode.D)) { dIsPressed = true; }
        if (Input.GetKey(KeyCode.LeftControl)) { leftCtrlIsPressed = true; }
        if (Input.GetKey(KeyCode.Space)) { spaceIsPressed = true; }

        if (Input.GetKeyUp(KeyCode.W)) { wIsPressed = false; }
        if (Input.GetKeyUp(KeyCode.A)) { aIsPressed = false; }
        if (Input.GetKeyUp(KeyCode.S)) { sIsPressed = false; }
        if (Input.GetKeyUp(KeyCode.D)) { dIsPressed = false; }
        if (Input.GetKeyUp(KeyCode.LeftControl)) { leftCtrlIsPressed = false; }
        if (Input.GetKeyUp(KeyCode.Space)) { spaceIsPressed = false; }
    }

    public KeyCode GetKeyCode()
    {
        if (wIsPressed)
        {
            return KeyCode.W;
        }
        if (aIsPressed)
        {
            return KeyCode.A;
        }
        if (sIsPressed)
        {
            return KeyCode.S;
        }
        if (dIsPressed)
        {
            return KeyCode.D;
        }
        if (leftCtrlIsPressed)
        {
            return KeyCode.LeftControl;
        }
        if (spaceIsPressed)
        {
            return KeyCode.Space;
        }
        return KeyCode.ScrollLock; // Using ScrollLock as a null value;
    }*/
}
