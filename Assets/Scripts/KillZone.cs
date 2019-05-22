using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class KillZone : MonoBehaviour
{
    public FirstPersonController vida;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.health -= 1000;
            if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero > 50)
            {
                GameMaster.instanciaCompartida.dinero -= 50;
            }
            else if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero < 50)
            {
                GameMaster.instanciaCompartida.dinero = 0;
            }
        }
    }
}
