using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Barras : MonoBehaviour
{
    [SerializeField]
    private Image barra;
    public int tipoDeBarra;
    HerramientaSeleccionada conex;

    void Start()
    {
        conex = GameObject.Find("JugadorUI").GetComponent<HerramientaSeleccionada>();
    }

    void Update()
    {
        if(tipoDeBarra==1)
        {
            ValorBarra();
        }
        else if(tipoDeBarra==2)
        {
            ValorBarra2();     
        }  
    }

    private void ValorBarra()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        barra.fillAmount = playerScript.stamina*.01f;
    }

    private void ValorBarra2()
    {       
        barra.fillAmount = conex.estaminaS * .01f;
    }
}
