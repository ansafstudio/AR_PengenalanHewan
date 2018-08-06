using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {
    public GameObject MainMenu; //variable untuk mendeklarasikan objek Main Menu
    public GameObject Tentang; //variable untuk mendeklarasikan objek Menu Tentang
    public GameObject CaraMain; //variable untuk mendeklarasikan objek Menu Cara Main

    public GameObject inGameButton; ////variable untuk mendeklarasikan objek button di dalam AR

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Mulai() //function untuk memulai AR atau saat tombol Mulai ditekan
    {
        MainMenu.SetActive(false);
        Tentang.SetActive(false);
        CaraMain.SetActive(false);

        inGameButton.SetActive(true);
    }

    public void OpenTentang() //funtion untuk membuka Menu Tentang
    {
        MainMenu.SetActive(false);
        Tentang.SetActive(true);
        CaraMain.SetActive(false);

        inGameButton.SetActive(false);
    }

    public void OpenCaraMain() //function untuk membuka Menu Cara Main
    {
        MainMenu.SetActive(false);
        Tentang.SetActive(false);
        CaraMain.SetActive(true);

        inGameButton.SetActive(false);
    }

    public void BackToMainMenu() // function untuk kembali ke Menu Utama
    {
        MainMenu.SetActive(true);
        Tentang.SetActive(false);

        inGameButton.SetActive(false);
    }

    public void ExitApp() //function untuk keluar dari applikasi AR
    {
        Application.Quit();
    }
}
