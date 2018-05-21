using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMutator : MonoBehaviour {

    Rocket rocket;

	void Awake () { // TODO Expand code to add data to multiple lists depending on the type of GameObject.
        rocket = GameObject.Find("Base").GetComponent<Rocket>();
        rocket.flameParticles.Add(gameObject);
	}
    // TODO Add code to remove gameObject when destroyed.
}
