using UnityEngine;
using System.Collections;

public class DeathOnCollision : MonoBehaviour {

	void OnCollisionEnter(Collision hit) {
		Destroy(gameObject);
	}

}
