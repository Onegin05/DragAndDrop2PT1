using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject CementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject Eskavators;
	public GameObject Policija;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject UgunsDz;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 CementaMKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 EskavatorsKoord;
	[HideInInspector]
	public Vector2 PolicijaKoord;
	[HideInInspector]
	public Vector2 Traktors1Koord;
	[HideInInspector]
	public Vector2 Traktors5Koord;
	[HideInInspector]
	public Vector2 UgunsDzKoord;


	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;
		
		b2Koord =
			autobuss.GetComponent<RectTransform>().localPosition;
		
		CementaMKoord =
			autobuss.GetComponent<RectTransform>().localPosition;

		e46Koord =
			autobuss.GetComponent<RectTransform>().localPosition;

		e61Koord =
			autobuss.GetComponent<RectTransform>().localPosition;

		EskavatorsKoord =
			autobuss.GetComponent<RectTransform>().localPosition;

		PolicijaKoord =
			autobuss.GetComponent<RectTransform>().localPosition;

		Traktors1Koord =
			autobuss.GetComponent<RectTransform>().localPosition;

		Traktors5Koord =
			autobuss.GetComponent<RectTransform>().localPosition;

		UgunsDzKoord =
			autobuss.GetComponent<RectTransform>().localPosition;


}
}
