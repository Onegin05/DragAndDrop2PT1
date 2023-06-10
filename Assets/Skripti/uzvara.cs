using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking.NetworkSystem;
using System;

public class uzvara : MonoBehaviour { 
	public GameObject uzvaraPanel ; //  Publiska GameObject mainīgā "uzvaraPanel" deklarācija.
	public Text laiksText ; 
	public GameObject star1 ; 
	public GameObject star2 ; 
	public GameObject star3 ; 
	public GameObject timer;

	public int MasinaSavaVieta = 0; // Publiska vesela skaitļa mainīgā "MasinaSavaVieta" deklarācija un inicializācija ar vērtību 0.
	
	void Start () {
		MasinaSavaVieta = 0;
		uzvaraPanel.SetActive (false);

	}
	

	public void rezultats () {
		timer.SetActive (false); // Deaktivizē "timer" objektu, iestatot to kā neaktīvu.
		star1.SetActive (false);//  Deaktivizē "star1" objektu, iestatot to kā neaktīvu.
		star2.SetActive (false);
			star3.SetActive (false);

		uzvaraPanel.SetActive (true);  //Aktivizē "uzvaraPanel" objektu, iestatot to kā aktīvu.
		laiksText.text = Timer.Laiksget (false);
		int sec = Convert.ToInt32 (Timer.Laiksget (true));
		if (sec / 60 < 3) {
			star1.SetActive (true); // //Aktivizē "star1" objektu, iestatot to kā aktīvu.
			star2.SetActive (true);
			star3.SetActive (true);
		} else if (sec / 60 < 2) {
			star1.SetActive (true);
			star2.SetActive (true);
		} else {
			star1.SetActive (true);
		}
		}
	}

