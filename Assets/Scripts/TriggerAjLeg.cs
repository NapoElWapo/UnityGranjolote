using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAjLeg : MonoBehaviour
{
    [SerializeField]
    int waypoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

        }
    }
}
