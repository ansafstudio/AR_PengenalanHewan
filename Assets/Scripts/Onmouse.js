//Script made by StrupsGames

var ani : Animator;
var sound : AudioClip;


function Start () {
	ani.enabled = false;
}

function OnMouseDown () {
	AudioSource.PlayClipAtPoint(sound, transform.position);
	ani.enabled = true;
	{
		yield WaitForSeconds (2);
		ani.enabled = false;
		
	}	
}

