using UnityEngine;
using System.Collections;

public class DisableComponetOnClick : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown(0) )
		{
			guiText.enabled = false;
		}	
	}
}
