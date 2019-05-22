using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCancion : MonoBehaviour
{
    public AudioClip nuevaCancion;
    //private GameMaster GM;

    BoxCollider boxCollider;
    void Start()
    {
        //GM = FindObjectOfType<GameMaster>();
        boxCollider = gameObject.GetComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (nuevaCancion != null)      
            GameMaster.instanciaCompartida.CambiarMusica(nuevaCancion);
        }
    }
}
