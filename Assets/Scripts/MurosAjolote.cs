using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurosAjolote : MonoBehaviour
{
   // public gameObject pos;
    public int pos;
    public static MurosAjolote instancia;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
