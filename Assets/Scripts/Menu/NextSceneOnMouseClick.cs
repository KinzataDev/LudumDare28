using UnityEngine;
using System.Collections;

public class NextSceneOnMouseClick : MonoBehaviour {

	public string scene = "";

	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown(0) ) {
			Application.LoadLevel(scene);
		}
	}
}
