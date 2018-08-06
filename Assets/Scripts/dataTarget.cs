using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
	public class dataTarget : MonoBehaviour
	{



		//Beruang
		public Transform beruang_grup;
		public Transform beruang_hidung;
		public Transform beruang_kaki;
		public Transform beruang_mata;
		public Transform beruang_mulut;
		public Transform beruang_tangan;
		public Transform beruang_telinga;
		public Transform beruang_infoindo;
		public Transform beruang_infoing;
				//Beruang end

		//Cheetah
		public Transform cheetah_grup;
		public Transform cheetah_ekor;
		public Transform cheetah_hidung;
		public Transform cheetah_kaki;
		public Transform cheetah_mata;
		public Transform cheetah_mulut;
		public Transform cheetah_tangan;
		public Transform cheetah_telinga;
		public Transform cheetah_infoindo;
		public Transform cheetah_infoing;
		//Cheetah end
	
		//Gajah	
		public Transform gajah_grup;
		public Transform gajah_ekor;
		public Transform gajah_kaki;
		public Transform gajah_mata;
		public Transform gajah_gading;
		public Transform gajah_tangan;
		public Transform gajah_telinga;
		public Transform gajah_infoindo;
		public Transform gajah_infoing;
		//Gajah end

		//Kangguru	
		public Transform kangguru_grup;
		public Transform kangguru_ekor;
		public Transform kangguru_hidung;
		public Transform kangguru_kaki;
		public Transform kangguru_mata;
		public Transform kangguru_mulut;
		public Transform kangguru_tangan;
		public Transform kangguru_telinga;
		public Transform kangguru_infoindo;
		public Transform kangguru_infoing;
		//Kangguru end

		//Zebra	
		public Transform zebra_grup;
		public Transform zebra_ekor;
		public Transform zebra_hidung;
		public Transform zebra_kaki;
		public Transform zebra_mata;
		public Transform zebra_mulut;
		public Transform zebra_tangan;
		public Transform zebra_telinga;
		public Transform zebra_infoindo;
		public Transform zebra_infoing;
		//Zebra end

		public AudioSource soundTarget;
		public AudioClip clipTarget;
	
		// Use this for initialization
		void Start()
		{
			beruang_grup.gameObject.SetActive(false);
			cheetah_grup.gameObject.SetActive(false);
			gajah_grup.gameObject.SetActive(false);
			kangguru_grup.gameObject.SetActive(false);
			zebra_grup.gameObject.SetActive (false);
			//add Audio Source as new game object component
			soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
		}



		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                //Cheetah
                //if(name == "cheetah"){
                if (name == "Citah")
                {
                    cheetah_grup.gameObject.SetActive(true);
					beruang_grup.gameObject.SetActive (false);
					gajah_grup.gameObject.SetActive (false);
					kangguru_grup.gameObject.SetActive (false);
					zebra_grup.gameObject.SetActive (false);
					//cheetah_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//cheetah_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//cheetah_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//cheetah_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//cheetah_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//cheetah_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//cheetah_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////cheetah_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoCitah_full"); });
					//cheetah_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Citah Inggris"); });

				}
				if(name == "cheetah2"){
					cheetah_grup.gameObject.SetActive(true);
					beruang_grup.gameObject.SetActive (false);
					gajah_grup.gameObject.SetActive (false);
					kangguru_grup.gameObject.SetActive (false);
					zebra_grup.gameObject.SetActive (false);
					//cheetah_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//cheetah_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//cheetah_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//cheetah_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//cheetah_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//cheetah_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//cheetah_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////cheetah_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoCitah_full"); });
					//cheetah_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Citah Inggris"); });

				}

                //if(name == "beruang"){
                if (name == "BeruangKutub")
                {
                    cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					kangguru_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(true);
					zebra_grup.gameObject.SetActive (false);
					//beruang_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//beruang_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//beruang_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//beruang_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//beruang_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//beruang_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////beruang_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoBeruang_full"); });
					//beruang_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Beruang Kutub Inggris"); });

				}
				if(name == "beruang2"){
					cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					kangguru_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(true);
					zebra_grup.gameObject.SetActive (false);
					//beruang_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//beruang_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//beruang_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//beruang_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//beruang_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//beruang_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////beruang_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoBeruang_full"); });
					//beruang_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Beruang Kutub Inggris"); });

				}
                //if(name == "gajah"){
                if (name == "Gajah")
                {
                    cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (true);
					kangguru_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					zebra_grup.gameObject.SetActive (false);
					//gajah_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//gajah_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//gajah_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//gajah_gading.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Gading"); });
					//gajah_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//gajah_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////gajah_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoGajah_full"); });
					//gajah_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Gajah Inggris"); });
				
				}if(name == "gajah2"){
					cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (true);
					kangguru_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					zebra_grup.gameObject.SetActive (false);
					//gajah_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//gajah_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//gajah_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//gajah_gading.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Gading"); });
					//gajah_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//gajah_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////gajah_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoGajah_full"); });
					//gajah_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Gajah Inggris"); });


				}

                //if(name == "kanguru"){
                if (name == "Kanguru")
                {
                    cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					kangguru_grup.gameObject.SetActive (true);
					zebra_grup.gameObject.SetActive (false);
					kangguru_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					kangguru_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					kangguru_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					kangguru_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					kangguru_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					kangguru_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					kangguru_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					//kangguru_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoKanguru_full"); });
					kangguru_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kanguru Inggris"); });

				}
				if(name == "kanguru2"){
					cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					kangguru_grup.gameObject.SetActive (true);
					zebra_grup.gameObject.SetActive (false);
					kangguru_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					kangguru_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					kangguru_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					kangguru_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					kangguru_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					kangguru_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					kangguru_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					//kangguru_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoKanguru_full"); });
					kangguru_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kanguru Inggris"); });

				}

                //if(name == "zebra"){
                if (name == "Zebra")
                {
                    cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					kangguru_grup.gameObject.SetActive (false);
					zebra_grup.gameObject.SetActive (true);
					//zebra_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//zebra_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//zebra_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//zebra_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//zebra_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//zebra_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//zebra_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////zebra_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoZebra_full"); });
					//zebra_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Zebra Inggris"); });

				}
				if(name == "zebra2"){
					cheetah_grup.gameObject.SetActive(false);
					gajah_grup.gameObject.SetActive (false);
					beruang_grup.gameObject.SetActive(false);
					kangguru_grup.gameObject.SetActive (false);
					zebra_grup.gameObject.SetActive (true);
					//zebra_ekor.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Ekor"); });
					//zebra_kaki.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Kaki"); });
					//zebra_hidung.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Hidung"); });
					//zebra_mata.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mata"); });
					//zebra_mulut.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mulut"); });
					//zebra_tangan.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Tangan"); });
					//zebra_telinga.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Telinga"); });
					////zebra_infoindo.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Info_new/InfoZebra_full"); });
					//zebra_infoing.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Zebra Inggris"); });

				}
			}
		}

		//function to play sound
		void playSound(string ss){
			clipTarget = (AudioClip)Resources.Load(ss);
			soundTarget.clip = clipTarget;
			soundTarget.loop = false;
			soundTarget.playOnAwake = false;
			soundTarget.Play();
		}
	}
}
