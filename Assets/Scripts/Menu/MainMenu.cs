using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin menuSkin;
	public float areaWidth;
	public float areaHeight;

	public float x_pos = 0.5f;
	public float y_pos = 0.5f;

	void OnGUI()
	{
		GUI.skin = menuSkin;
		
		float ScreenX = ((Screen.width * x_pos) - (areaWidth * 0.5f));
		float ScreenY = ((Screen.height * y_pos) - (areaHeight * 0.5f));
		
		GUILayout.BeginArea( new Rect(ScreenX,ScreenY, areaWidth, areaHeight));
		
		if( GUILayout.Button("Launch Me"))
		{
			Application.LoadLevel("Main");
		}
		GUILayout.Label("                 ");
		if( GUILayout.Button("How To Survive"))
		{
			Application.LoadLevel("instructions_1");
		}
		GUILayout.Label("                 ");
		if( GUILayout.Button("Quit"))
		{
			Application.Quit();
		}
		GUILayout.EndArea();
	}
}
