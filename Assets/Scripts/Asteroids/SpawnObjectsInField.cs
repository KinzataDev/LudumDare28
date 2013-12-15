using UnityEngine;
using System.Collections;

public class SpawnObjectsInField : MonoBehaviour {

	public GameObject[] objectsToSpawn;

	public float width = 0;
	public float height = 0;
	public float depth = 0;
	public bool spawning = true;

	public float time_between_spawns = 3;
	public float spawn_per_cycle = 5;

	public float max_scale = 3;
	public float min_scale = 0.5f;
	public float max_speed = 100f;
	public float min_speed = 35f;

    private float time_for_spawn = 0;
	private int max_spawn_attempts = 5;

	// Update is called once per frame
	void Update () {
		time_for_spawn += Time.deltaTime;

		if( time_for_spawn >= time_between_spawns )
		{
			time_for_spawn = 0;
			Spawn();
		}
	}

	private void Spawn() {
		int attempts = 0;
		for( int i=0; i < spawn_per_cycle; i++ ) {
			attempts = 0;
			while( attempts < max_spawn_attempts ) {
				attempts++;

				float x = (Random.value * width) - (width * 0.5f);
				float y = (Random.value * height) - (height * 0.5f);
				float z = (Random.value * depth) - (depth * 0.5f);
				Vector3 point = new Vector3(x,y,z) + transform.position;

				GameObject spawnMe = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

				GameObject newObj = Instantiate(spawnMe,point,Quaternion.identity) as GameObject;
				float scale = Random.Range(min_scale, max_scale);
				newObj.transform.localScale *= scale;

				Vector3 velocity = Random.onUnitSphere;
				float speed = Random.Range(min_speed, max_speed);

				velocity = velocity * speed;
				newObj.rigidbody.velocity = velocity;

				attempts = max_spawn_attempts;
			}
		}

	}
	void OnDrawGizmos()
	{
		Vector3 position = transform.position;
		Gizmos.DrawWireCube(position, new Vector3(width,height,depth));
	}
}
