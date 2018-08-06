using UnityEngine;
using System.Collections;

public class LoadArtarian : MonoBehaviour {


	void start(){
		
	}
	// mainmenu
public void Mulai(){
	Application.LoadLevel("Vuforia-5-Mulai");
	}

	public void Keluar(){
		Application.Quit();
	}

	public void Cara(){
		Application.LoadLevel("Vuforia-4-Cara");
	}

	public void Tentang(){
		Application.LoadLevel("Vuforia-4-Tentang");
	}

	public void Kembali(){
		Application.LoadLevel("Vuforia-3-Mulai");
	}
}
