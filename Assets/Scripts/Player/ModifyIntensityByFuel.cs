using UnityEngine;
using System.Collections;

public class ModifyIntensityByFuel : MonoBehaviour {

	public float max_intensity = 0.9f;
	public float min_intensity = 0.25f;
	private float base_intensity;

	void Start() {
		base_intensity = max_intensity - min_intensity;
	}

	void OnEnable() {
		FuelCanister.OnFuelUsed += HandleOnFuelUsed;
		DeathOnCollision.OnPlayerDeath += HandleOnPlayerDeath;
	}

	void HandleOnPlayerDeath ()
	{
		light.flare = null;
	}

	void HandleOnFuelUsed (float fuel_left)
	{
		float percent = 1 - (fuel_left / FuelCanister.INITIAL_FUEL);
		light.intensity = base_intensity * percent + min_intensity;
	}

	void OnDisable() {
		FuelCanister.OnFuelUsed -= HandleOnFuelUsed;
		DeathOnCollision.OnPlayerDeath -= HandleOnPlayerDeath;
	}
}
