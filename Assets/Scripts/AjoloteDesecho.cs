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
        yield return new WaitForSecondsRealtime(tiempoDesecho);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        StopCoroutine(GenerarDesecho());
    }

    public void recogerDesecho()
    {
        this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        corrutina = true;
    }
}