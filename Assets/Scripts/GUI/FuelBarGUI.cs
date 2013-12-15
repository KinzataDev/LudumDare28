using UnityEngine;
using System.Collections;

public class FuelBarGUI : MonoBehaviour {

	public GUITexture[] bars;

	// Use this for initialization
	void Start () {
		float offset = 1.0f / (bars.Length + 1);
		for( int i=0; i < bars.Length; i++ ) {
			Vector3 scale = Vector3.zero;
			scale.x = 0.055f;
			scale.y = 0.55f;
			bars[i].transform.localScale = scale;

			Vector3 position = Vector3.zero;
			position.x = offset * (i+1f) - 0.5f;
			bars[i].transform.localPosition = position;
		}
	}

	void OnEnable()
	{
		FuelCanister.OnFuelUsed += UpdateGUI;
	}

	void OnDisable()
	{
		FuelCanister.OnFuelUsed -= UpdateGUI;
	}

// The logic in here is not what I intended to have happen... but the emergent behvaior of the
// fuel bar depleting in an odd way was really cool to see, so I left it.
	void UpdateGUI(float fuel_left)
	{
		int bar_num = Mathf.FloorToInt((fuel_left / FuelCanister.INITIAL_FUEL) * bars.Length);
		float fade = fuel_left % 10;

		Color current_color = bars[bar_num].guiTexture.color;
		current_color.a = fade;
		bars[bar_num].guiTexture.color = current_color;
	}
}
