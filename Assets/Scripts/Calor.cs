using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Calor : MonoBehaviour
{
    public RectTransform imagenCalor;
    public bool quemandose=false,resistencia=false;
    MenuInventario conex;
    slot amuleto;
    TiendaUI comprar;
    LogrosYMisiones conexML;
    public GameObject current_selected_obj, ASF,ASFApagado;
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexML = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
        comprar = GameObject.Find("TiendaUI").GetComponent<TiendaUI>();
    }

    private void OnTriggerStay(Collider collision)
	{
        
        if (collision.gameObject.CompareTag("Player"))
		{
            quemandose = true;
            if (resistencia==false)
            {
                GameObject Jugador = GameObject.FindWithTag("Player");
                FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
                playerScript.dolor = true;
                playerScript.health -= 1;
                if (quemandose == true)
                {
                    comprar.poderComprarAF = true;
                    ASFApagado.gameObject.SetActive(true);
                    conexML.quemado = true;
                    imagenCalor.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
                }

                if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero > 50)
                {
                    GameMaster.instanciaCompartida.dinero -= 50;
                }
                else if (playerScript.health <= 0 && GameMaster.instanciaCompartida.dinero < 50)
                {
                    GameMaster.instanciaCompartida.dinero = 0;
                }
            }
            NPC2.instancia.calor = true;
        }

        foreach (var iterador in conex.herramientas)
        {
            if (iterador.RealItemName == "AjoloteApagado")
            {
                current_selected_obj = ASF.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            }
        }


    }

    public void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.dolor = false;
        }
    }

    void Update()
    {
        amuleto = conex.pasivas.Find(x => x.Slot_name == "Slot1");
        if (amuleto.RealItemName == "AmuletoFuego")
        {
            resistencia = true;
        }
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        if (playerScript.health >= 100)
        {
            quemandose = false;
        }
        if (quemandose)
        {
            imagenCalor.GetComponent<CanvasGroup>().alpha = 1f - (playerScript.health * .01f);
            
        }
    }
}
