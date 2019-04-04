using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Calor : MonoBehaviour
{

	void OnCollisionStay(Collision collision)
	{	
		if(collision.gameObject.CompareTag("Player"))
		{
			GetComponent<FirstPersonController>().health = GetComponent<FirstPersonController>().health-10;
			Debug.Log("Eo");
		}
	}
}
