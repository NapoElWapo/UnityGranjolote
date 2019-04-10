using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Calor : MonoBehaviour
{
    public FirstPersonController vida;
   
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider collision)
	{	
		if(collision.gameObject.CompareTag("Player"))
		{

            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.health -= 1;
        }

	}


    
    
}
