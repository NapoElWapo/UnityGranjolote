using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteCriadero : MonoBehaviour
{
    RectTransform slotActual;
    public RectTransform ajoloteP, ajoloteA, ajoloteF, ajoloteH, ajoloteN, ajoloteD, ajoloteL, nuevoSlot;
    private RectTransform ajoloteActual, doradoTemp;

    public GameObject botonesCriadero;

    int slot = 0;

    public void dejarAjolote()
    {
        if (slot<10 && ajoloteActual == ajoloteD)
        {
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
            Instantiate(ajoloteActual, slotActual.transform);
            slot++;
            ajoloteActual = doradoTemp;
        }
        else if (slot<10 && ajoloteActual != null)
        {
        slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
        Instantiate(ajoloteActual, slotActual.transform);
        slot++;
        Debug.Log("Se dejo un ajolote");
            if (slot > 0)
                botonesCriadero.gameObject.SetActive(false);
        } 
    }

    public void recogerAjolote()
    {
        if(slot>0)
        {
        slot--;
        slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
        Destroy(GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>().GetChild(2).gameObject);  
        }

        if (slot == 0)
        {
            botonesCriadero.gameObject.SetActive(true);
            ajoloteActual = null;
        }
    }

    public void CriaderoTipoPlanta()
    {
        ajoloteActual = ajoloteP;
    }

    public void CriaderoTipoAgua()
    {
        ajoloteActual = ajoloteA;
    }

    public void CriaderoTipoFuego()
    {
        ajoloteActual = ajoloteF;
    }

    public void CriaderoTipoHielo()
    {
        ajoloteActual = ajoloteH;
    }

    public void CriaderoTipoNube()
    {
        ajoloteActual = ajoloteN;
    }

    public void CriaderoTipoDorado()
    {
        if (ajoloteActual != ajoloteD)
        {
            doradoTemp = ajoloteActual;
            ajoloteActual = ajoloteD;
        }
    }

    public void CriaderoTipoLegendario()
    {
        ajoloteActual = ajoloteL;
    }
}
