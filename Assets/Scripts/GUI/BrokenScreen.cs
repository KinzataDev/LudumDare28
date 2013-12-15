using UnityEngine;
using System.Collections;

public class BrokenScreen : MonoBehaviour {

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

	void OnEnable() {
		DeathOnCollision.OnPlayerDeath += Show;
	}

	void OnDisable() {
		DeathOnCollision.OnPlayerDeath -= Show;
	}

	void Show() {
		Color currentColor = guiTexture.color;
		currentColor.a = 0.4f;
		guiTexture.color = currentColor;
	}

}
