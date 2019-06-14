using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteDesecho : MonoBehaviour
{
    public GameObject boton, current_selected_obj;
    public bool corrutina = false;
    public bool resetTim = false;
    public float tiempoDesecho;
    public float tiempoVar, timerkk;
    public bool alimentado, feliz, muyFeliz;

    Reloj rejol;

    void Start()
    {
        boton = GetComponent<GameObject>();
        rejol = GameObject.Find("HoraMinuto").GetComponent<Reloj>();
    }

    void Update()
    {
        Timer();
        ImagenFeliz();
        ChecarReloj();
    }

    void Timer()
    {
        if (!alimentado && resetTim)
        {
            timerkk = tiempoDesecho;
            resetTim = false;
        }
        if(alimentado && resetTim)
        {
            timerkk = tiempoVar;
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

    public void recogerDesecho()
    {
        this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        corrutina = true;
        resetTim = true;
        //current_selected_obj = desecho.transform.gameObject;
        GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
    }

    void ImagenFeliz()
    {
        if (feliz)
            this.gameObject.transform.GetChild(3).gameObject.SetActive(true);

        if(muyFeliz)
            this.gameObject.transform.GetChild(4).gameObject.SetActive(true);

        if (!feliz)
            this.gameObject.transform.GetChild(3).gameObject.SetActive(false);

        if (!muyFeliz)
            this.gameObject.transform.GetChild(4).gameObject.SetActive(false);
    }

    void ChecarReloj()
    {
        if(GameMaster.instanciaCompartida.hora == 23 && GameMaster.instanciaCompartida.minuto >= 59)
        {
            Debug.Log("falso ajolotin");
            alimentado = false;
            feliz = false;
            muyFeliz = false;
        }
    }
}