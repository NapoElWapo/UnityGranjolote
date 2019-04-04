using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Calor : MonoBehaviour
{
    public int vida;
    


    void Start()
    {
        vida = GetComponent<FirstPersonController>().health;
    }
    private void OnCollisionStay(Collision collision)
	{	
		if(collision.gameObject.CompareTag("Player"))
		{
            vida = vida - 10;
			Debug.Log("Eo");
		}

	}


    /*void Update()
	{
		void OnCollisionStay(Collision collision)
		{	
			if(collision.gameObject.CompareTag("Player"))
			{
				GetComponent<FirstPersonController>().health = GetComponent<FirstPersonController>().health-10;
				Debug.Log("Eo");
			}
		}
	}*/
    
}
