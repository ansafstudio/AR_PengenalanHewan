using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour {
	public Animator ani;
	protected Animator animator;


	void start(){
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Cheetah
	public void c_ekor(){

		ani.SetTrigger("ekor");
	}
	public void c_hidung(){

		ani.SetTrigger("hidung");
	}
	public void c_mata(){

		ani.SetTrigger("mata");
	}
	public void c_kaki(){

		ani.SetTrigger("kaki");
	}
	public void c_mulut(){

		ani.SetTrigger("mulut");
	}
	public void c_tangan(){

		ani.SetTrigger("tangan");
	}
	public void c_telinga(){

		ani.SetTrigger("telinga");
	}
	//Cheetah


	//Beruang

	public void beruang_hidung(){

		ani.SetTrigger("beruang_hidung");
	}
	public void beruang_mata(){

		ani.SetTrigger("beruang_mata");
	}
	public void beruang_kaki(){

		ani.SetTrigger("beruang_kaki");
	}
	public void beruang_mulut(){

		ani.SetTrigger("beruang_mulut");
	}
	public void beruang_tangan(){

		ani.SetTrigger("beruang_tangan");
	}
	public void beruang_telinga(){

		ani.SetTrigger("beruang_telinga");
	}
	//Beruang end


	//Gajah 
	public void gajah_ekor(){

		ani.SetTrigger("gajah_ekor");
	}
	public void gajah_gading(){

		ani.SetTrigger("gajah_gading");
	}
	public void gajah_kaki(){

		ani.SetTrigger("gajah_kaki");
	}
	public void gajah_mata(){

		ani.SetTrigger("gajah_mata");
	}
	public void gajah_tangan(){

		ani.SetTrigger("gajah_tangan");
	}
	public void gajah_telinga(){

		ani.SetTrigger("gajah_telinga");
	}
	//Gajah end

	//Kangguru 
	public void kangguru_ekor(){

		ani.SetTrigger("kangguru_ekor");
	}
	public void kangguru_mulut(){

		ani.SetTrigger("kangguru_mulut");
	}
	public void kangguru_kaki(){

		ani.SetTrigger("kangguru_kaki");
	}
	public void kangguru_mata(){

		ani.SetTrigger("kangguru_mata");
	}

	public void kangguru_hidung(){

		ani.SetTrigger("kangguru_hidung");
	}

	public void kangguru_tangan(){

		ani.SetTrigger("kangguru_tangan");
	}
	public void kangguru_telinga(){

		ani.SetTrigger("kangguru_telinga");
	}
	//Kangguru end

	//Zebra 
	public void zebra_ekor(){

		ani.SetTrigger("zebra_ekor");
	}
	public void zebra_mulut(){

		ani.SetTrigger("zebra_mulut");
	}
	public void zebra_kaki(){

		ani.SetTrigger("zebra_kaki");
	}
	public void zebra_mata(){

		ani.SetTrigger("zebra_mata");
	}

	public void zebra_hidung(){

		ani.SetTrigger("zebra_hidung");
	}

	public void zebra_tangan(){

		ani.SetTrigger("zebra_tangan");
	}
	public void zebra_telinga(){

		ani.SetTrigger("zebra_telinga");
	}
	//Zebra end
}
