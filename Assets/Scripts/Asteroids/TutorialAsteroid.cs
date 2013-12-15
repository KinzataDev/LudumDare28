using UnityEngine;
using System.Collections;

public class TutorialAsteroid : MonoBehaviour {

	public Vector3 velocity;

	// Update is called once per frame
	void Update () {
		rigidbody.velocity = velocity;	
	}
}
