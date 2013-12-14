using UnityEngine;
using System.Collections;

public class KeyboardMovement : MonoBehaviour {

	public float base_force = 2.0f;
	public float base_fuel_usage = 1.0f;
	private FuelCanister fuel;

	void Start() {
		fuel = gameObject.GetComponent<FuelCanister>();
	}

	// Update is called once per frame
	void Update () {
		float delta = Time.deltaTime;
		float fuel_usage = base_fuel_usage;
		float force = base_force;

		bool expulsion = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
		if( expulsion ) {
			fuel_usage *= 5;
			force *= 6;
		}

		if( Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ) {
			if( fuel.deplete(fuel_usage * delta) ) {
				gameObject.rigidbody.AddForce(new Vector3(-force,0,0));
			}
		}
		if( Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ) {
			if( fuel.deplete(fuel_usage * delta) ) {
				gameObject.rigidbody.AddForce(new Vector3(force,0,0));
			}
		}
		if( Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ) {
			if( fuel.deplete(fuel_usage * delta) ) {
				gameObject.rigidbody.AddForce(new Vector3(0,force,0));
			}
		}
		if( Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ) {
			if( fuel.deplete(fuel_usage * delta) ) {
				gameObject.rigidbody.AddForce(new Vector3(0,-force,0));
			}
		}
	}
}
