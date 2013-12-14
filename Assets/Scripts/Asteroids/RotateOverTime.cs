using UnityEngine;
using System.Collections;

public class RotateOverTime : MonoBehaviour {

	public float speed = 2.0f;

	public Vector3 rotationVector;

	void Start() {
		rotationVector = Random.insideUnitSphere;
	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(rotationVector * Time.deltaTime * speed);
	}
}
