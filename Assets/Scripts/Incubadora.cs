using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Incubadora : MonoBehaviour
{
    public RectTransform items, ajolotesincu, incubadora1, incubadora2, incubadora3, incubadoraUI;
    slot itemslot1, itemslot2, itemslot3, itemslot4,itemslot5,itemslot6,itemslot7,itemslot8;
    public Image sslot1, sslot2, sslot3, sslot4,sslot5,sslot6,sslot7,sslot8, slotIncu1, slotIncu2, slotIncu3;

    public RectTransform bslot1, bslot2, bslot3, bslot4,bslot5,bslot6,bslot7,bslot8;
    private int slotSeleccionado=0;
    MenuInventario conex;
    public bool incuP, incuA, incuF, incuH, incuN, incuO,incubando,incuT;
    public GameObject current_selected_obj,huevoP,huevoA,huevoF,huevoH,huevoN,huevoO,ajoP,ajoA,ajoF,ajoH,ajoN,ajoO;

    public float tEspera;

    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    void Update()
    {
        itemslot1 = conex.coleccionables.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = itemslot1.Slot_ui_img.sprite;

        itemslot2 = conex.coleccionables.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = itemslot2.Slot_ui_img.sprite;

        itemslot3 = conex.coleccionables.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = itemslot3.Slot_ui_img.sprite;

        itemslot4 = conex.coleccionables.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = itemslot4.Slot_ui_img.sprite;

        itemslot5 = conex.coleccionables.Find(x => x.Slot_name == "Slot5");
        sslot5.sprite = itemslot5.Slot_ui_img.sprite;

        itemslot6 = conex.coleccionables.Find(x => x.Slot_name == "Slot6");
        sslot6.sprite = itemslot6.Slot_ui_img.sprite;

        itemslot7 = conex.coleccionables.Find(x => x.Slot_name == "Slot7");
        sslot7.sprite = itemslot7.Slot_ui_img.sprite;

        itemslot8 = conex.coleccionables.Find(x => x.Slot_name == "Slot8");
        sslot8.sprite = itemslot8.Slot_ui_img.sprite;

        if(incubando==true)
        {
            Timer();
        }

    }

    public void Seleccionar1()
    {
        slotSeleccionado = 1;
        bslot1.gameObject.SetActive(true);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar2()
    {
        slotSeleccionado = 2;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(true);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar3()
    {
        slotSeleccionado = 3;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(true);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar4()
    {
        slotSeleccionado = 4;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(true);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar5()
    {
        slotSeleccionado = 5;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(true);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar6()
    {
        slotSeleccionado = 6;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(true);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar7()
    {
        slotSeleccionado = 7;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(true);
        bslot8.gameObject.SetActive(false);
    }

    public void Seleccionar8()
    {
        slotSeleccionado = 8;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(true);
    }

    public void BotonIItems()
    {
        GameMaster.instanciaCompartida.mostrarAIncubadora = true;
        GameMaster.instanciaCompartida.mostrarIIncubadora = false;

        items.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAIncubadora);
        ajolotesincu.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIIncubadora);
    }
    public void BotonAItems()
    {
        GameMaster.instanciaCompartida.mostrarAIncubadora = false;
        GameMaster.instanciaCompartida.mostrarIIncubadora = true;

        items.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAIncubadora);
        ajolotesincu.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIIncubadora);
    }

    public void Incubar()
    {
        switch(slotSeleccionado)
        {
            case 1:

                if (itemslot1.RealItemName == "HuevoPlanta" && incubando == false&&incuT==false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot1.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot1.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot1.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot1.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot1.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot1.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
               
               

                break;

            case 2:
                if (itemslot2.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot2.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot2.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot2.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot2.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot2.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot2.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;

            case 3:
                if (itemslot3.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot3.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot3.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot3.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot3.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot3.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot3.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;

            case 4:
                if (itemslot4.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot4.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot4.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot4.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot4.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot4.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot4.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;

            case 5:
                if (itemslot5.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot5.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot5.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot5.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot5.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot5.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot5.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }

                break;

            case 6:
                if (itemslot6.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot6.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot6.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot6.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot6.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot6.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot6.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;

            case 7:
                if (itemslot7.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot7.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot7.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot7.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot7.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot7.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot7.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;

            case 8:
                if (itemslot8.RealItemName == "HuevoPlanta" && incubando == false && incuT == false)
                {
                    Debug.Log("incube planta");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuP = true;
                    incubando = true;
                    tEspera = 10f;


                }
                else if (itemslot8.RealItemName == "HuevoAgua" && incubando == false && incuT == false)
                {
                    Debug.Log("incube agua");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuA = true;
                    incubando = true;
                    tEspera = 15f;
                }
                else if (itemslot8.RealItemName == "HuevoFuego" && incubando == false && incuT == false)
                {
                    Debug.Log("incube fuego");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuF = true;
                    incubando = true;
                    tEspera = 20f;
                }
                else if (itemslot8.RealItemName == "HuevoHielo" && incubando == false && incuT == false)
                {
                    Debug.Log("incube hielo");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuH = true;
                    incubando = true;
                    tEspera = 30f;
                }
                else if (itemslot8.RealItemName == "HuevoNube" && incubando == false && incuT == false)
                {
                    Debug.Log("incube nube");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuN = true;
                    incubando = true;
                    tEspera = 50f;
                }
                else if (itemslot8.RealItemName == "HuevoOro" && incubando == false && incuT == false)
                {
                    Debug.Log("incube oro");
                    slotIncu1.sprite = itemslot8.Slot_ui_img.sprite;
                    current_selected_obj = huevoO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    incuO = true;
                    incubando = true;
                    tEspera = 77f;
                }
                break;
        }
    }

    
    void Timer()
    {
        if(incuP==true)
        { 
            tEspera = tEspera - Time.deltaTime;
            if(tEspera<=0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoP.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
        else if (incuA == true)
        {
            tEspera = tEspera - Time.deltaTime;
            if (tEspera <= 0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoA.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
        else if (incuF == true)
        {
            tEspera = tEspera - Time.deltaTime;
            if (tEspera <= 0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoF.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
        else if (incuH == true)
        {
            tEspera = tEspera - Time.deltaTime;
            if (tEspera <= 0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoH.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
        else if (incuN == true)
        {
            tEspera = tEspera - Time.deltaTime;
            if (tEspera <= 0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoN.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
        else if (incuO == true)
        {
            tEspera = tEspera - Time.deltaTime;
            if (tEspera <= 0)
            {
                Debug.Log("Nacio Ajolote");
                slotIncu1.sprite = ajoO.GetComponent<ItemInventario>().Inventory_Decal;
                incubando = false;
                incuT = true;
            }
        }
    }

    public void Recoger()
    {
        //slot1
        if (incuP == true&& incuT==true)
        {
            current_selected_obj = ajoP.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuP = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
        else if (incuA == true && incuT == true)
        {
            current_selected_obj = ajoA.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuA = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
        else if (incuF == true && incuT == true)
        {
            current_selected_obj = ajoF.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuF = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
        else if (incuH == true && incuT == true)
        {
            current_selected_obj = ajoH.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuH = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
        else if (incuN == true && incuT == true)
        {
            current_selected_obj = ajoN.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuN = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
        else if (incuO == true && incuT == true)
        {
            current_selected_obj = ajoO.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
            incuO = false;
            incuT = false;
            slotIncu1.sprite = null;
        }
    }

    public void Incubadora1()
    {
        Debug.Log("Si entra");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 0.0F;
        mouseLook.YSensitivity = 0.0F;
        Time.timeScale = 0f;
        GameMaster.instanciaCompartida.mostrarIncubadora1 = true;
        GameMaster.instanciaCompartida.mostrarIncubadora2 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora3 = false;

        incubadora1.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora1);
        incubadora2.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora2);
        incubadora3.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora3);
    }

    public void Incubadora2()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 0.0F;
        mouseLook.YSensitivity = 0.0F;
        Time.timeScale = 0f;
        GameMaster.instanciaCompartida.mostrarIncubadora1 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora2 = true;
        GameMaster.instanciaCompartida.mostrarIncubadora3 = false;

        incubadora1.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora1);
        incubadora2.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora2);
        incubadora3.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora3);
    }

    public void Incubadora3()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 0.0F;
        mouseLook.YSensitivity = 0.0F;
        Time.timeScale = 0f;
        GameMaster.instanciaCompartida.mostrarIncubadora1 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora2 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora3 = true;

        incubadora1.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora1);
        incubadora2.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora2);
        incubadora3.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora3);
    }

    public void ToggleIncubadora()
    {
        GameMaster.instanciaCompartida.mostrarIncubadoraUI = !GameMaster.instanciaCompartida.mostrarIncubadoraUI;
        incubadoraUI.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadoraUI);

        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 2F;
        mouseLook.YSensitivity = 2F;
        Time.timeScale = 1f;
    } 
}
