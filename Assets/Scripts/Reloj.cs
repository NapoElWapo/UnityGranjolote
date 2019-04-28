using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Reloj : MonoBehaviour
{
    private Text textClock;
    public int hora;
    public float minuto;
    public float tiempoTotal;
    public Transform solTransform;
    public Transform lunaTransform;


    


    void Start()
    {
        textClock = GetComponent<Text>();
    }

    void Update()
    {


        hora = GameMaster.instanciaCompartida.hora;
        minuto = GameMaster.instanciaCompartida.minuto;
       

        if (hora == 0)
        {
            tiempoTotal = minuto;
        }
        else
        {
            tiempoTotal = (hora * 60) + minuto;
        }





        if (minuto > 10 && hora < 10)
        {
            textClock.text = "0" + hora + ":" + (int)minuto;
        }
        else if (hora > 9 && minuto < 10)
        {
            textClock.text = hora + ":0" + (int)minuto;
        }
        else if (hora >= 10 && minuto >= 10)
        {
            textClock.text = hora + ":" + (int)minuto;
        }
        else
        {
            textClock.text = "0" + hora + ":0" + (int)minuto;
        }

        solTransform.rotation = Quaternion.Euler(new Vector3((tiempoTotal * 0.25f) - 90, 0, 0));
        lunaTransform.rotation = Quaternion.Euler(new Vector3((tiempoTotal * 0.25f) + 90, 0, 0));

    }

  
}