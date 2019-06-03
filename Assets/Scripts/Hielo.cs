using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hielo : MonoBehaviour
{
    public GameObject hielo;
    private float limite;

    private void OnTriggerStay(Collider other)
    {
            if (other.tag == "Agua"||other.tag=="Agua2")
            {
                hielo.transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
                hielo.transform.position += new Vector3(0, 0.005f, 0);
            }
            else if (other.tag == "Fuego" || other.tag == "Fuego2")
            {
                hielo.transform.localScale -= new Vector3(0.005f, 0.005f, 0.005f);
                hielo.transform.position -= new Vector3(0, 0.005f, 0);
            }      
    }
}
