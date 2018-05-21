using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    ParticleSystem _particleSystem;

    public List<GameObject> flameParticles = new List<GameObject>(); // Here we create a list to store our ParticleSystem Gameobjects. We will use these stored GameObjects to toggle the "Thruster" sequence.

    // Use this for initialization
    void Start () {
        foreach(GameObject flame in flameParticles)
        {
            //print(flame);
            _particleSystem = flame.GetComponent<ParticleSystem>();
            var main = _particleSystem.main;
            main.startSpeed = 0;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
