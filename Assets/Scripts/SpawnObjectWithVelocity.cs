using UnityEngine;
using System.Collections;

public class SpawnObjectWithVelocity : MonoBehaviour {

	public Vector3 cannonVelocity = new Vector3(50,0,0);
	public GameObject objectToSpawn;
	private bool spawned = false;

	void Update()
	{
		if( !spawned && Input.GetMouseButtonDown(0) )
		{
			this.Spawn();
		}
	}

	void Spawn()
	{
		GameObject newObject = Instantiate( objectToSpawn, this.gameObject.transform.position, Quaternion.identity ) as GameObject;
		newObject.rigidbody.velocity = cannonVelocity;
		spawned = true;
	}

}
