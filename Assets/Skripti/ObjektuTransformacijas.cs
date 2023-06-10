using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacijas : MonoBehaviour {
	public Objekti objektuSkripts;

	void Update()
	{
		if (objektuSkripts.pedejaisVilktais != null) // Pārbauda, vai "pedejaisVilktais" mainīgais objektuSkripts klasē nav null.
		{
			if (Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().Rotate(0, 0, Time.deltaTime * 9f); //  Rotē "pedejaisVilktais" objektu, izmantojot RectTransform komponenti, pa laikrindu "Time.deltaTime * 9f" ap Z asi.
			}
			if (Input.GetKey(KeyCode.X))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().Rotate(0, 0, -Time.deltaTime * 9f);
			}

			if (Input.GetKey(KeyCode.UpArrow))
			{
				if (objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.y <= 2f) // Pārbauda, vai "pedejaisVilktais" objekta RectTransform komponentes Y mērogojums ir mazāks vai vienāds ar 2f.
				{
					objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVilktais.
								GetComponent<RectTransform>().transform.localScale.y + 0.002f); //  Iestata "pedejaisVilktais" objekta RectTransform komponentes Y mērogojumu, pievienojot tam vērtību 0.002f.
				}
			}

			if (Input.GetKey(KeyCode.DownArrow))
			{
				if (objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.y >= 0.10f) //  Pārbauda, vai "pedejaisVilktais" objekta RectTransform komponentes Y mērogojums ir lielāks vai vienāds ar 0.10f.
				{
					objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.y - 0.002f);
				}
			}


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x >= 0.10f)
                {
                    objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.x - 0.002f,
                        objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.y);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x <= 2f)
                {
                    objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.x + 0.002f,
                        objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
	}
}

