﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	public uzvara U; // Deklarē publisko mainīgo "U" no klases "uzvara".
	private float vietasZRot, velkObjZRot, rotacijasStarpiba; 
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

	public void OnDrop(PointerEventData eventData) //  Definē metodi, kas tiek izsaukta, kad objekts tiek nomests uz šīs vietas.
    {
		if (eventData.pointerDrag != null) // Pārbauda, vai pārnēsājamais objekts ir definēts.
		{
			if (eventData.pointerDrag.tag.Equals(tag)) // -Pārbauda, vai pārnēsājamā objekta atzīme (tag) atbilst šīs vietas atzīmei (tag).
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
					Mathf.Abs(vietasZRot - velkObjZRot); // Aprēķina rotācijas starpību starp nomestā objekta un vietas rotācijām.

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1)) //  - Pārbauda, vai rotācijas starpība un izmēru starpības ir mazākas vai vienādas ar noteiktām vērtībām, kas norāda pareizu nomesto objektu pozīciju.
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;
					U.MasinaSavaVieta++;
					if (U.MasinaSavaVieta == 12) {
						uzvara uzvRezultats = FindObjectOfType<uzvara>(); //  Izsauc "rezultats" metodi no "uzvara" objekta.
						uzvRezultats.rezultats();


					}
					switch (eventData.pointerDrag.tag) {
					case "atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (
							objektuSkripts.skanasKoAtskanot [1]);
						
							break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
						
							break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
						

							break;
					
					    case "b2":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[4]);
						
							break;
					    case "camentaM":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[5]);
						
							break;
						case "e46":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[6]);
					
							break;
						case "e61":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[7]);
						
							break;
						case "eskavators":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[8]);
						
							break;
						case "policija":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[9]);
						
							break;
						case "traktorsDzeltenais":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[10]);
						
							break;
						case "traktorsZilais":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[11]);
						
							break;
						case "ugunsDz":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[12]);
						
							break;










						default:
							Debug.Log("Tags nav definēts!");
							break;

					}


				}


			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;
				case "b2":
					objektuSkripts.b2.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.b2Koord;
					break;
				case "CementaM":
					objektuSkripts.CementaMasina.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.CementaMKoord;
					break;
				case "e46":
					objektuSkripts.e46.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.e46Koord;
					break;
				case "e61":
					objektuSkripts.e61.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.e61Koord;
					break;
				case "Eskavators":
					objektuSkripts.Eskavators.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.EskavatorsKoord;
					break;
				case "Policija":
					objektuSkripts.Policija.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.PolicijaKoord;
					break;
				case "Traktors1":
					objektuSkripts.Traktors1.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.Traktors1Koord;
					break;
				case "Traktors5":
					objektuSkripts.Traktors5.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.Traktors5Koord;
					break;
				case "UgunsDz":
					objektuSkripts.UgunsDz.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.UgunsDzKoord;
					break;




                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}
}
