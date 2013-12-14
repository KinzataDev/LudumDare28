using UnityEngine;
using System.Collections;

public class MoveCameraWithMouse : MonoBehaviour {

	public float rotationSpeedFactor = 1f;

	private float h_rot = 0;
	private float v_rot = 0;

	// Update is called once per frame
	void Update () {
		v_rot = Input.GetAxis("Mouse X") * rotationSpeedFactor;
		h_rot = Input.GetAxis("Mouse Y") * rotationSpeedFactor;
		transform.Rotate(-h_rot,v_rot,0);
	}
}
