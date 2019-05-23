using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteDesecho : MonoBehaviour
{

    public GameObject boton;
    bool corrutina = false;
    public float tiempoDesecho;
    float tiempoPasado = 0f;
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (corrutina)
        {
            StartCoroutine(GenerarDesecho());
        }  
    }

    IEnumerator GenerarDesecho()
    {
        corrutina = false;
        //yield return new WaitForSeconds(4);
        yield return new WaitForSecondsRealtime(tiempoDesecho);
        Debug.Log("salio popo");
        //boton.gameObject.SetActive(false);
        //GameObject.Find("BotonDesecho").SetActive(true);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        StopCoroutine(GenerarDesecho());
    }

    /*public void sacarPopo()
    {
        transform.GetChild(2).gameObject.SetActive(true);
        Debug.Log("salio popo");
        tiempoPasado = 99;
        funcion = false;
    }*/

    public void recogerDesecho()
    {
        //boton.gameObject.SetActive(false);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        //StartCoroutine(GenerarDesecho());
        //corrutina = true;
        corrutina = true;
    }
}