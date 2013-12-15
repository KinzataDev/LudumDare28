using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	private float score;
	private float score_multiplier;

	// Use this for initialization
	void Start () {
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		score += score_multiplier * Time.deltaTime; 
		guiText.text = score.ToString();
	}

	void OnEnable() {
		SpawnObjectWithVelocity.OnStartGame += Reset;
	}

	void OnDisable() {
		SpawnObjectWithVelocity.OnStartGame -= Reset;
	}

	void Reset() {
		score = 0;
		score_multiplier = 1;
	}
}
