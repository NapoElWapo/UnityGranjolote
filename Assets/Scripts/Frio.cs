using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Frio : MonoBehaviour
{
    public RectTransform imagenFrio;
    public bool congelandose=false;
    

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            congelandose = true;
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.dolor = true;
            playerScript.health -= 1;
            if(congelandose==true)
            {
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
            NPC2.instancia.frio = true;
        }
    }


    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            congelandose = false;
            playerScript.dolor = false;
        }
    }
    void Update()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        if(congelandose==true)
        {
            imagenFrio.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
        }
        
        
    }
}
