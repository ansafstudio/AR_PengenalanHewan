using UnityEngine;
using System.Collections;

public class Kembali_Tarian : MonoBehaviour {
public GUISkin guiSkin;
	public float guiRatio;
	public float sWidth;
	public Vector3 GUIsF;

	void Awake(){
		sWidth = Screen.width;
		guiRatio = sWidth/1020;
		GUIsF = new Vector3(guiRatio, guiRatio,1);
	}
	
	void OnGUI(){
		
		GUI.skin = guiSkin;
		
		Layar();
	
}

void Layar(){
	if  (GUI.Button (new Rect(20, 30, 120, 50), "Kembali "))//Kembali
		{
			Application.LoadLevel("Vuforia-1-About");
		}
}

}