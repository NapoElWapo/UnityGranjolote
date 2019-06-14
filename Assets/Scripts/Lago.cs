using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lago : MonoBehaviour
{
    public GameObject pescaLanza, pescaArco;

    void Start()
    {
        pescaLanza = GameObject.Find("MiniPesca").GetComponent<GameObject>();
        pescaArco = GameObject.Find("ArcoMiniPesca").GetComponent<GameObject>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Lanza")
        {
            pescaLanza.gameObject.SetActive(true);
        }
        else if(other.tag=="Arco")
        {
            pescaArco.gameObject.SetActive(true);
        }
    }
}
