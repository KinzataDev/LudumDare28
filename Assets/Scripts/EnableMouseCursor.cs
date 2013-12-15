using UnityEngine;
using System.Collections;

public class EnableMouseCursor : MonoBehaviour {

	public bool enabled = true;
	// Use this for initialization
	void Start () {
		Screen.showCursor = enabled;
	}

}
