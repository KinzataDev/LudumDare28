using UnityEngine;
using System.Collections;

public class MoveCameraWithMouse : MonoBehaviour {

	public float rotationSpeedFactor = 1f;
	public float max_h_rot = 60f;
	public float max_v_rot = 60f;
	private float min_v_rot;
	private float min_h_rot;

	private float h_rot = 0;
	private float v_rot = 0;

	void Start() {
		min_v_rot = 360 - max_v_rot;
		min_h_rot = 360 - max_h_rot;
	}

	// Update is called once per frame
	void Update () {
		Vector3 rotation = transform.rotation.eulerAngles;
		Debug.Log(rotation);
		v_rot = rotation.x + (Input.GetAxis("Mouse Y") * rotationSpeedFactor * -1);
		if( v_rot < min_v_rot && v_rot > 180 )
		{
			v_rot = min_v_rot;
		}
		else if( v_rot > max_v_rot && v_rot < 180 )
		{
			v_rot = max_v_rot;
		}	
		h_rot = rotation.y + (Input.GetAxis("Mouse X") * rotationSpeedFactor);
		if( h_rot < min_h_rot && h_rot > 180 )
		{
			h_rot = min_h_rot;
		}
		else if( h_rot > max_v_rot && h_rot < 180 )
		{
			h_rot = max_h_rot;
		}

		Vector3 new_rotation = new Vector3(v_rot, h_rot, 0);
		transform.rotation = Quaternion.Euler(new_rotation);
	}
}
