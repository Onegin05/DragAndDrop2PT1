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
		laiksgo = 0;
		t = Laiksget(false);
		textBox.GetComponent<Text>().text = t;
	}


	public static string Laiksget(bool Seconds) {
		int h, m, s;
		s = Mathf.RoundToInt(laiksgo);
		if (Seconds)
		{
			return ""+s;
		}

		h = s/3600;
		s -= h*3600;
		m = s/60;
		s -= m*60;

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

		return t;
	}




	void Update () {
		laiksgo += Time.deltaTime;
		t = Laiksget (false);

		textBox.GetComponent<Text> ().text = t;
	}
}