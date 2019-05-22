﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Frio : MonoBehaviour
{
    public RectTransform imagenFrio;

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.health -= 1;
            imagenFrio.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
            if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero > 50)
            {
                GameMaster.instanciaCompartida.dinero -= 50;
            }
            else if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero < 50)
            {
                GameMaster.instanciaCompartida.dinero = 0;
            }
            NPC2.instancia.frio = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            for (int i = playerScript.health; i <= 100; i++)
            {
                playerScript.health += 1;
            }
        }
    }
}
