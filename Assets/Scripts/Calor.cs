using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Calor : MonoBehaviour
{
    public RectTransform imagenCalor;
    public bool quemandose=false;
    private void OnTriggerStay(Collider collision)
	{	
		if(collision.gameObject.CompareTag("Player"))
		{
            quemandose = true;
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.dolor = true;
            playerScript.health -= 1;
            if (quemandose==true)
            {
                imagenCalor.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
            }
            
            if(playerScript.health<=0 && GameMaster.instanciaCompartida.dinero > 50)
            {
                GameMaster.instanciaCompartida.dinero -= 50;
            }
            else if(playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero<50)
            {
                GameMaster.instanciaCompartida.dinero = 0;
            }
            NPC2.instancia.calor = true;
        }
	}

    public void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            quemandose = false;
            playerScript.dolor = false;
        }
    }

    void Update()
    {

        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        if(quemandose==true)
        {
            imagenCalor.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);

        }

    }

}
