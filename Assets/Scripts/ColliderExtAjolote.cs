using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderExtAjolote : MonoBehaviour
{
    public PatrullaAjolote ajolote;
    SphereCollider colliderExt;

    void Start()
    {
        //ajolote = GetComponent<PatrullaAjolote>();
        ajolote = GetComponentInParent<PatrullaAjolote>();
        colliderExt = GetComponent<SphereCollider>();
        colliderExt.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ajolote.TriggerJugador();
        }

        if (other.tag == "Agua" || other.tag == "Agua2")
        {
            ajolote.TriggerAgua();
        }

        if (other.tag == "Fuego" || other.tag == "Fuego2")
        {
            ajolote.TriggerFuego();
        }
    }
}
