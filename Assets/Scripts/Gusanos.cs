using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gusanos : MonoBehaviour
{
    public GameObject montonTierra, current_selected_obj, gusano;
    LogrosYMisiones conexLM;

    void Start()
    {
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rastrillo")
        {
            conexLM.contadorGusanos += 1;
            current_selected_obj = gusano.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            montonTierra.gameObject.SetActive(false);
        }
    }
}