using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking.NetworkSystem;
using System;

public class uzvara : MonoBehaviour { 
	public GameObject uzvaraPanel ;
	public Text laiksText ; 
	public GameObject star1 ; 
	public GameObject star2 ; 
	public GameObject star3 ; 
	public GameObject timer;

public int MasinaSavaVieta = 0;
	
	void Start () {
		uzvaraPanel.SetActive (false);

	}
	

	public void rezultats () {
		timer.SetActive (false);
		star1.SetActive (false);
		star2.SetActive (false);
			star3.SetActive (false);

		uzvaraPanel.SetActive (true);
		laiksText.text = Timer.Laiksget (false);
		int sec = Convert.ToInt32 (Timer.Laiksget (true));
		if (sec / 60 < 3) {
			star1.SetActive (true);
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

