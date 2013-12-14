using UnityEngine;
using System.Collections;

public class KeyboardMovement : MonoBehaviour {

	public float force = 2.0f;

	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ) {
			gameObject.rigidbody.AddForce(new Vector3(-force,0,0));
		}
		if( Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ) {
			gameObject.rigidbody.AddForce(new Vector3(force,0,0));
		}
		if( Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ) {
			gameObject.rigidbody.AddForce(new Vector3(0,force,0));
		}
		if( Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ) {
			gameObject.rigidbody.AddForce(new Vector3(0,-force,0));
		}
	}
}
