using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jaieiemportē, lai varētu strādāt at UI elementiem

using UnityEngine.UI;
public class VardaParadisana : MonoBehaviour
{
    //Mainīgaja saglabās tekstu ko raksta teksta laukā
    public string teksts;
    //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks;
    //Kur attēlot tekstu 
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiežot pogu

    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper() + "!";
    }
}