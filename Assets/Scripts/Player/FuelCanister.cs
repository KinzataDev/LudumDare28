using UnityEngine;
using System.Collections;

public class FuelCanister : MonoBehaviour {

	public delegate void FuelUsed(float fuel_left);
	public static event FuelUsed OnFuelUsed;
	public const float INITIAL_FUEL = 1000f;

	private float fuel;

	void Start() {
		fuel =  INITIAL_FUEL;
	}

	public bool deplete(float amount)
	{
		if( amount > fuel)
		{
			fuel = 0;
			Debug.Log("Fuel Empty!!!");
			return false;
		}

		Debug.Log("Fuel at: " + fuel);
		fuel -= amount;

		if(OnFuelUsed != null )
		{
			OnFuelUsed(fuel);
		}

		return true;
	}

	void ResetFuel() {
		fuel = INITIAL_FUEL;
	}

	void OnEnable() {
		SpawnObjectWithVelocity.OnStartGame += ResetFuel;
	}
	void OnDisable() {
		SpawnObjectWithVelocity.OnStartGame -= ResetFuel;
	}

}
