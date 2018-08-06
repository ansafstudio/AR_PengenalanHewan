using UnityEngine;
using System.Collections;

public class AturTarian : MonoBehaviour {

	
public GUISkin guiSkin;
	public float guiRatio;
	public float sWidth;
	public Vector3 GUIsF;
	

//verly ananda analyst system


	//objek tari
	public GameObject model_1;
	public GameObject model_2;
	public GameObject model_3;
	public GameObject model_4;
	public GameObject model_5;
	public GameObject model_6;
	public GameObject model_7;
	public GameObject model_8;
	public GameObject model_9;
	public GameObject model_10;
void Start(){
//model tari
model_1.SetActive(false);
model_2.SetActive(false);
model_3.SetActive(false);
model_4.SetActive(false);
model_5.SetActive(false);
model_6.SetActive(false);
model_7.SetActive(false);
model_8.SetActive(false);
model_9.SetActive(false);
model_10.SetActive(false);


//info

}

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
		//meletakan button di pojok kanan atas
	

		if  (GUI.Button (new Rect(20, 30, 120, 50), "Merak"))//1
		{
			
			model_1.SetActive(true);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

			//info

		}

		if  (GUI.Button (new Rect(20, 100, 120, 50), "Soon"))//2
		{
			model_1.SetActive(false);
			model_2.SetActive(true);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

		

		}
		if  (GUI.Button (new Rect(20, 170, 120, 50), "Soon"))//3
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(true);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

		
		}
		if  (GUI.Button (new Rect(20, 240, 120, 50), "Soon"))//4
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(true);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

		
		}
		if  (GUI.Button (new Rect(20, 310, 120, 50), "Soon"))//5
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(true);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

		
		}
		if  (GUI.Button (new Rect(20, 380, 120, 50), "Soon"))//6
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(true);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

		
		}
		if  (GUI.Button (new Rect(20, 450, 120, 50), "Soon"))//7
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(true);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(false);

			
		}
		if  (GUI.Button (new Rect(20, 520, 150, 60), "Soon"))//8
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(true);
			model_9.SetActive(false);
			model_10.SetActive(false);

			
		}
		if  (GUI.Button (new Rect(20, 590, 150, 50), "Soon "))//9
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(true);
			model_10.SetActive(false);
			
		}
		if  (GUI.Button (new Rect(20, 660, 120, 50), "Soon"))//10
		{
			model_1.SetActive(false);
			model_2.SetActive(false);
			model_3.SetActive(false);
			model_4.SetActive(false);
			model_5.SetActive(false);
			model_6.SetActive(false);
			model_7.SetActive(false);
			model_8.SetActive(false);
			model_9.SetActive(false);
			model_10.SetActive(true);
		
		}
		if  (GUI.Button (new Rect(240, 30, 120, 50), "Kembali "))//Kembali
		{
			Application.LoadLevel("Vuforia-1-About");
		}
}
}
