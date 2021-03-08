using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai lietotu pointer darbību interfeisu
//Papildus ir jāpārliecinās, ka projektā pie Canvas ir importēta EventSystem UI komponente
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,  IDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();
    }

    //Funkcija nostrādā, kad uzklikšķināts uz pārvietojamā objekta
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais klikšķis uz pārvietojamā objekta!");
    }

    //Funkcija nostrādā uzsākot pārvietošanas
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsāka pārvietošanu!");
    }

    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Vilkšana pabeigta!");
    }
}
