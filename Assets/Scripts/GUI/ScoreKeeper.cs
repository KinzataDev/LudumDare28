using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	private float score;
	private float score_multiplier;

	private float movement_timer;
	public float time_for_multiplier = 10f;

	private bool is_score_running = false;

	// Use this for initialization
	void Start () {
		score = 0;
		score_multiplier = 1;
		movement_timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		movement_timer += Time.deltaTime;
		if( movement_timer >= time_for_multiplier ) {
			score_multiplier += 1;
			movement_timer = 0;
		}
		if( is_score_running ) {
			score += score_multiplier * Time.deltaTime; 
			guiText.text = score_multiplier + "X - " +score.ToString();
		}
	}

	void HandleOnPlayerMoved ()
	{
		score_multiplier = 1;
		movement_timer = 0;
	}

	void Reset() {
		score = 0;
		score_multiplier = 1;
		movement_timer = 0f;
		is_score_running = true;
	}

	void HandleOnPlayerDeath ()
	{
		is_score_running = false;
	}

	void OnEnable() {
		SpawnObjectWithVelocity.OnStartGame += Reset;
		KeyboardMovement.OnPlayerMoved += HandleOnPlayerMoved;
		DeathOnCollision.OnPlayerDeath += HandleOnPlayerDeath;
	}


	void OnDisable() {
		SpawnObjectWithVelocity.OnStartGame -= Reset;
		KeyboardMovement.OnPlayerMoved -= HandleOnPlayerMoved;
		DeathOnCollision.OnPlayerDeath -= HandleOnPlayerDeath;
	}
}
