using UnityEngine;
using System.Collections;

public class DeathOnCollision : MonoBehaviour {

	public delegate void Death();
	public static event Death OnPlayerDeath;

	void OnCollisionEnter(Collision hit) {
	
		gameObject.GetComponentInChildren<MoveCameraWithMouse>().enabled = false;
		StartCoroutine("End");
	}

	IEnumerator End() {

		if( OnPlayerDeath != null )
		{
			OnPlayerDeath();
		}
		yield return new WaitForSeconds(2);
		GameObject.Find("FadeOutGUI").GetComponent<FadeOutScene>().FadeOut("Menu");
	}

}
