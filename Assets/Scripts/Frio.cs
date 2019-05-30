using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Frio : MonoBehaviour
{
    public RectTransform imagenFrio;
    public bool congelandose=false,resistencia=false;
    MenuInventario conex;
    slot amuleto;
    TiendaUI comprar;
    LogrosYMisiones conexLM;
    Notificaciones conexN;
    private bool noti;
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
        comprar = GameObject.Find("TiendaUI").GetComponent<TiendaUI>();
        conexN = GameObject.Find("NotificacionesDeslizantes").GetComponent<Notificaciones>();
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            if (resistencia==false)
            {
                GameObject Jugador = GameObject.FindWithTag("Player");
                FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
                playerScript.dolor = true;
                congelandose = true;
                playerScript.health -= 1;
                if (congelandose == true)
                {
                    comprar.poderComprarAH = true;
                    if (noti == false)
                    {
                        conexN.popO();
                        noti = true;
                    }
                    conexLM.congelado = true;
                    imagenFrio.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
                }
               
                if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero > 50)
                {
                    GameMaster.instanciaCompartida.dinero -= 50;
                }
                else if (playerScript.health <= 0f && GameMaster.instanciaCompartida.dinero < 50)
                {
                    GameMaster.instanciaCompartida.dinero = 0;
                }
            }
            NPC2.instancia.frio = true;
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            
            playerScript.dolor = false;
        }
    }

    void Update()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        amuleto = conex.pasivas.Find(x => x.Slot_name == "Slot3");
        if (amuleto.RealItemName == "AmuletoHielo")
        {
            resistencia = true;
        }
        if(playerScript.health >=100)
        {
            congelandose = false;
        }     
       if(congelandose==true)
        {         
            imagenFrio.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
        }      
    }
}
