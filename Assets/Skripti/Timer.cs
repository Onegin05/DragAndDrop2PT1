using UnityEngine.Networking.NetworkSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class Timer : MonoBehaviour {
	public static float laiksgo;
	public GameObject textBox;

	private static string t;


	void Start () {
		laiksgo = 0;  //  Iestata "laiksgo" mainīgā vērtību uz 0.
		t = Laiksget(false); // Iegūst laika tekstu, izmantojot "Laiksget" funkciju ar parametru "false".
		textBox.GetComponent<Text>().text = t; // estata "textBox" objekta tekstu uz vērtību "t".
	}


	public static string Laiksget(bool Seconds) { // Publiska statiska funkcija "Laiksget" ar bool tipa parametru "Seconds".
		int h, m, s;
		s = Mathf.RoundToInt(laiksgo); //  Iestata "s" vērtību noapaļojot "laiksgo" uz tuvāko veselo skaitli.
		if (Seconds)
		{
			return ""+s; // Atgriež skaitli "s" kā tekstu.
		}

		h = s/3600;  // Aprēķina stundas, dalot "s" ar 3600 un ievietojot rezultātu "h".
		s -= h*3600; //  Izņem no "s" skaitļa stundas, reizinot "h" ar 3600.
		m = s/60; //  Aprēķina minūtes, dalot atlikušo "s" ar 60 un ievietojot rezultātu "m".
		s -= m*60; // Izņem no "s" skaitļa minūtes, reizinot "m" ar 60.

		string a, b, c;

		if (s < 10) {
			c = ":0" + s;
		} else {
			c = ":" + s;
		}

		if (m < 10) {
			b = ":0" + m;
		} else {
			b = ":" + m;
		}

		if (h < 10) {
			a = "0" + h;
		} else {
			a = "" + h;
		}

		t = a+b+c;

		return t; //  Atgriež tekstu "t".
	}




	void Update () {
		laiksgo += Time.deltaTime; // Palielina "laiksgo" vērtību par pagājušo laiku kopš pēdējā kadra.
		t = Laiksget (false); // Iegūst laika tekstu, izmantojot "Laiksget" funkciju ar parametru "false".

		textBox.GetComponent<Text> ().text = t;
	}
}