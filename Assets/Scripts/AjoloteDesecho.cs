using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteDesecho : MonoBehaviour
{

    public GameObject boton;
    bool funcion = false;
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
        if (funcion)
        {
            if (tiempoPasado >= 99)
                tiempoPasado = 0f;
            tiempoPasado += Time.deltaTime;
            if (tiempoPasado >= tiempoDesecho)
                sacarPopo();
        }
        Debug.Log(tiempoPasado);  
    }

    IEnumerator GenerarDesecho()
    {
        //corrutina = false;
        yield return new WaitForSeconds(4);
        Debug.Log("salio popo");
        boton.gameObject.SetActive(false);
        //GameObject.Find("BotonDesecho").SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        StopCoroutine(GenerarDesecho());
    }

    public void sacarPopo()
    {
        transform.GetChild(2).gameObject.SetActive(true);
        Debug.Log("salio popo");
        tiempoPasado = 99;
        funcion = false;
    }

    public void recogerDesecho()
    {
        //boton.gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        //StartCoroutine(GenerarDesecho());
        //corrutina = true;
        funcion = true;
    }
}