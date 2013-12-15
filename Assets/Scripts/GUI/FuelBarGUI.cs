using UnityEngine;
using System.Collections;

public class FuelBarGUI : MonoBehaviour {

	public GUITexture[] bars;

	// Use this for initialization
	void Start () {
		Rect rect = guiTexture.pixelInset;
		float width = rect.width;
		float offset = (width / (bars.Length + 1)) + 1.8f;
		for( int i=0; i < bars.Length; i++ ) {
			Rect bar_rect = bars[i].guiTexture.pixelInset;
			bar_rect.x = offset * (i+0.5f) - (width / 2);
			bars[i].guiTexture.pixelInset = bar_rect;
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
