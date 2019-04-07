using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Calor : MonoBehaviour
{ 

    void Start()
    {
        
    }
    private void OnTriggerStay(Collider collision)
	{	
		if(collision.gameObject.CompareTag("Player"))
		{

            Debug.Log("Eo");
		}

	}


    
    
}
