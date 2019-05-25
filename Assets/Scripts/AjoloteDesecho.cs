using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteDesecho : MonoBehaviour
{

    public GameObject boton, current_selected_obj;
    public bool corrutina = false;
    public bool resetTim = false;
    public float tiempoDesecho;
    public float timerkk;

    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (resetTim)
        {
            timerkk = tiempoDesecho;
            resetTim = false;
        }
        if (corrutina)
        {
            timerkk -= Time.deltaTime;
            if (timerkk <= 0)
            {
                this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
                corrutina = false;
            }
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
        resetTim = true;
        //current_selected_obj = desecho.transform.gameObject;
        GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
    }
}