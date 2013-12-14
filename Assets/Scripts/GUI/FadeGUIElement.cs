using UnityEngine;
using System.Collections;

public class FadeGUIElement : MonoBehaviour {

	public float initial_opacity = 0f;
	public float to_alpha;
	private float current_alpha;

	// Use this for initialization
	void Start () {
		Color currentColor = guiTexture.color;
		currentColor.a = initial_opacity;
		guiTexture.color = currentColor;

		current_alpha = initial_opacity;
	}

	void Update() {

		if( to_alpha == current_alpha ) { return; }

		current_alpha = Mathf.Lerp(current_alpha, to_alpha, Time.deltaTime / 10000f);

		Color currentColor = guiTexture.color;
		currentColor.a = current_alpha;
		guiTexture.color = currentColor;
	}


}
