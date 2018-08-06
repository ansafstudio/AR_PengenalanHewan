using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMgr : MonoBehaviour {
	public GameObject[] imageObjek; // varibale untuk mendeklarasikan gambar bagian tubuh
	public AudioSource makananAudio; // variable untuk mendeklarasikan sound makanan
	//public AudioSource makananAudio2;

    public AudioSource infoAudio; // variable untuk mendeklarasikan sound informasi

    public AudioSource[] SoundTubuh; // variable untuk mendeklarasikan sound bagian tubuh

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowImageInfo(int a) // function untuk menampilkan gambar keterangan saat di tekan tombol bagian tubuh
	{
		for (int i = 0; i < imageObjek.Length; i++) {
			if (a == i) {
				imageObjek [i].SetActive (true);
			} else {
				imageObjek [i].SetActive (false);
			}
		}

		if (a==0) {
            StopAllSound();
            imageObjek[0].SetActive(false);
			makananAudio.Play();
		}
	}

	public void CloseImageInfo()  //function untuk menutup gambar keterangan info tubuh
	{
		for (int i = 0; i < imageObjek.Length; i++) {
			imageObjek[i].SetActive(false);
		}

		makananAudio.Stop ();
		infoAudio.Stop ();

        for (int i = 0; i < SoundTubuh.Length; i++)
        {
            SoundTubuh[i].Stop();
        }
	}

	public void PlayInfoAudio() // function untuk membunyikan sound saat klik tombol Informasi
	{
        CloseImageInfo();
        StopAllSound();
        imageObjek[1].SetActive(false);
        infoAudio.Play ();
	}

    public void PlaySoundTubuh(int index) // function untuk membunyikan sound saat klik tombol bagian tubuh
    {
        StopAllSound();
        SoundTubuh[index].Play();
    }

    void StopAllSound() // function untuk men stop seluruh sound
    {
        for (int i = 0; i < SoundTubuh.Length; i++)
        {
            SoundTubuh[i].Stop();
        }

        makananAudio.Stop();
        infoAudio.Stop();
    }

}
