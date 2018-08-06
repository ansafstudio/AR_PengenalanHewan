using UnityEngine;
using System.Collections;

public class Info : MonoBehaviour {

	public Transform target1;
	public GameObject gameobjek;
	public string info1;
 public Vector2 scrollPosition1 = Vector2.zero;
	public bool show=false;
	public Animator ani;
   public AudioSource suara;
   protected Animator animator;


   void start(){
   	animator = GetComponent<Animator> ();
   }
	void Update(){
		if(Input.GetMouseButton(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast (ray, out hit)){
				if(hit.transform == target1){
							
							 ani.SetTrigger("ani");
			       			suara.Play();
				}
				
			}
		}
}

void OnMouseDown() {
	
}
}
