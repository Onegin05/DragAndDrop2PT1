using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāieimportē, lai varētu lietot visus I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, 
    IPointerDownHandler, IBeginDragHandler, 
    IDragHandler, IEndDragHandler {
    //Uzglabā norādi uz Objekti skriptu
    public Objekti objektuSkripts;
    //Velkamam objektam piestiprinātā CanvasGoup komponente
    private CanvasGroup kanvasGrupa;
    //Objekta atrašanās vieta, kurš tiek pārvietots
    private RectTransform velkObjRectTransf;

    void Start()
    {
        //Piekļūst objektam piestiprinātajai CanvasGroup
        //komponentei
        kanvasGrupa = GetComponent<CanvasGroup>();
        //Piekļūst objeta RectTransform komponentei
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzklikšķināts uz velkama objekta!");
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    //Turpināsim no šīs vietas
	public void OnDrag(PointerEventData eventData) //šī rindiņa definē metodi, kas tiek izsaukta, kamēr objekts tiek vilkts.
    {
        velkObjRectTransf.anchoredPosition +=
        eventData.delta / objektuSkripts.kanva.scaleFactor; 
    }

	public void OnEndDrag(PointerEventData eventData)// šī rindiņa definē metodi, kas tiek izsaukta, kad objekts tiek nomests pēc vilkšanas.
    {
        objektuSkripts.pedejaisVilktais =
             eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if(objektuSkripts.vaiIstajaVieta == false) {
            kanvasGrupa.blocksRaycasts = true;

        } else {
            objektuSkripts.pedejaisVilktais = null;
        }

        objektuSkripts.vaiIstajaVieta = false;
    }

	public void OnPointerDown(PointerEventData eventData) //šī rindiņa definē metodi, kas tiek izsaukta, kad uz objekta tiek noklikšķināts ar peles pogu.
    {
        
    }
}
