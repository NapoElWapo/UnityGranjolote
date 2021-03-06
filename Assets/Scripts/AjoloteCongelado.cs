﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteCongelado : MonoBehaviour
{
    public GameObject hielo, ajo1, ajo2,flamable;
    public int vidaHielo=100;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Fuego" || other.tag == "Fuego2")
        {
            vidaHielo--;
            if(vidaHielo<=0)
            {
                StartCoroutine(Quemarse());
            }   
        }     
    }

    IEnumerator Quemarse()
    {
        flamable.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        hielo.gameObject.SetActive(false);
        ajo1.gameObject.SetActive(false);
        flamable.gameObject.SetActive(false);
        ajo2.gameObject.SetActive(true);
    }
}
