using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public float currentSpeed = 0f;
    public float maxSpeed = 2000f;

    public Vector3 currentPosition;

    public List<GameObject> flameParticles = new List<GameObject>(); // Here we create a list to store our ParticleSystem Gameobjects. We will use these stored GameObjects to toggle the "Thruster" sequence.

    // Use this for initialization
    void Start () {
        foreach(GameObject flame in flameParticles)
        {
            print(flame);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
