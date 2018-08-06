using UnityEngine;
using System.Collections;

public class AturOBJ : MonoBehaviour {

public GUISkin guiSkin;
	public float guiRatio;
	public float sWidth;
	public Vector3 GUIsF;
	

//verly ananda analyst system
	//cube info
	public GameObject cube_1;
	public GameObject cube_2;
	public GameObject cube_3;
	public GameObject cube_4;
	public GameObject cube_5;
	public GameObject cube_6;
	public GameObject cube_7;
	public GameObject cube_8;
	public GameObject cube_9;
	public GameObject cube_10;

	//objek alatmusik
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
//model alat musik
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
cube_1.SetActive(false);
cube_2.SetActive(false);
cube_3.SetActive(false);
cube_4.SetActive(false);
cube_5.SetActive(false);
cube_6.SetActive(false);
cube_7.SetActive(false);
cube_8.SetActive(false);
cube_9.SetActive(false);
cube_10.SetActive(false);
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
	

		if  (GUI.Button (new Rect(20, 30, 120, 50), "Angklung"))//1
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

			cube_1.SetActive(true);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);

		}

		if  (GUI.Button (new Rect(20, 100, 120, 50), "Arumba"))//2
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(true);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);

		}
		if  (GUI.Button (new Rect(20, 170, 120, 50), "Calung"))//3
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(true);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 240, 120, 50), "Celempung"))//4
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(true);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 310, 120, 50), "Jentreng"))//5
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(true);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 380, 120, 50), "Karinding"))//6
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(true);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 450, 120, 50), "Kecapi"))//7
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(true);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 520, 150, 60), "Rebab"))//8
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

			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(true);
			cube_9.SetActive(false);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 590, 150, 50), "Suling "))//9
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
			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(true);
			cube_10.SetActive(false);
		}
		if  (GUI.Button (new Rect(20, 660, 120, 50), "Tarawangsa"))//10
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
			//info
			cube_1.SetActive(false);
			cube_2.SetActive(false);
			cube_3.SetActive(false);
			cube_4.SetActive(false);
			cube_5.SetActive(false);
			cube_6.SetActive(false);
			cube_7.SetActive(false);
			cube_8.SetActive(false);
			cube_9.SetActive(false);
			cube_10.SetActive(true);
		}

		if  (GUI.Button (new Rect(240, 30, 120, 50), "Kembali "))//Kembali
		{
			Application.LoadLevel("Vuforia-1-About");
		}
	}

}