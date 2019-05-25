using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TiendaUI : MonoBehaviour
{

    public RectTransform  producto1, producto2, producto3, producto4, producto5, producto6, tiendaUI,botonComprarArco, botonComprarAmuletoFuego, botonComprarAmuletoHielo;
    private bool p1=false, p2=false, p3=false, p4=false, p5=false, p6=false,lc=false,ac=false,afc=false,ahc=false,rc=false;
    public GameObject current_selected_obj,lanza,arco,rastrillo,AF,AH, comida, cacaP, cacaA, cacaF, cacaH, cacaN, cacaO,cacaL;
    public bool poderComprarArco=false, poderComprarAF=false, poderComprarAH=false;
    public int dinero;
    public Text uiDinero;

    private int ventanaActiva;

    slot itemslot1, itemslot2, itemslot3, itemslot4, itemslot5, itemslot6, itemslot7, itemslot8;
    MenuInventario conex;
    public RectTransform bslot1, bslot2, bslot3, bslot4, bslot5, bslot6, bslot7, bslot8, precioAF1, precioAF2, precioAH1, precioAH2;
    private int slotSeleccionado = 0;
    public Image sslot1, sslot2, sslot3, sslot4, sslot5, sslot6, sslot7, sslot8;
    public Text stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8;
    LogrosYMisiones conexLM;
    // Start is called before the first frame update
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexLM= GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
    }

    // Update is called once per frame
    void Update()
    {
        uiDinero.text = "Oro : " + GameMaster.instanciaCompartida.dinero;

        itemslot1 = conex.coleccionables.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = itemslot1.Slot_ui_img.sprite;
        stack1.text = itemslot1.Slot_stack.text;

        itemslot2 = conex.coleccionables.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = itemslot2.Slot_ui_img.sprite;
        stack2.text = itemslot2.Slot_stack.text;

        itemslot3 = conex.coleccionables.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = itemslot3.Slot_ui_img.sprite;
        stack3.text = itemslot3.Slot_stack.text;

        itemslot4 = conex.coleccionables.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = itemslot4.Slot_ui_img.sprite;
        stack4.text = itemslot4.Slot_stack.text;

        itemslot5 = conex.coleccionables.Find(x => x.Slot_name == "Slot5");
        sslot5.sprite = itemslot5.Slot_ui_img.sprite;
        stack5.text = itemslot5.Slot_stack.text;

        itemslot6 = conex.coleccionables.Find(x => x.Slot_name == "Slot6");
        sslot6.sprite = itemslot6.Slot_ui_img.sprite;
        stack6.text = itemslot6.Slot_stack.text;

        itemslot7 = conex.coleccionables.Find(x => x.Slot_name == "Slot7");
        sslot7.sprite = itemslot7.Slot_ui_img.sprite;
        stack7.text = itemslot7.Slot_stack.text;

        itemslot8 = conex.coleccionables.Find(x => x.Slot_name == "Slot8");
        sslot8.sprite = itemslot8.Slot_ui_img.sprite;
        stack8.text = itemslot8.Slot_stack.text;

        botonComprarArco.gameObject.SetActive(conexLM.m3c);
        botonComprarAmuletoFuego.gameObject.SetActive(poderComprarAF);
        botonComprarAmuletoHielo.gameObject.SetActive(poderComprarAH);

        if(conexLM.m7c)
        {
            precioAF1.GetComponent<Text>().text = "Precio: 1500 oro";
            precioAF2.GetComponent<Text>().text = "Precio: 1500 oro";
        }

        if (conexLM.m8c)
        {
            precioAH1.GetComponent<Text>().text = "Precio: 2000 oro";
            precioAH2.GetComponent<Text>().text = "Precio: 2000 oro";
        }
    }

    public void Vender()
    {
        switch (slotSeleccionado)
        {
            case 1:

                if (itemslot1.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");
                    
                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot1.RealItemName == "CacaAgua" )
                {
                    Debug.Log("incube agua");
                   
                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot1.RealItemName == "CacaFuego")
                {
                    
                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot1.RealItemName == "CacaHielo")
                {
                    
                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot1.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");
                    
                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot1.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");
                    
                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot1.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }

                break;

            case 2:

                if (itemslot2.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot2.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot2.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot2.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot2.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot2.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot2.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 3:
                if (itemslot3.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot3.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot3.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot3.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot3.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot3.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot3.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 4:
                if (itemslot4.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot4.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot4.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot4.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot4.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot4.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot4.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 5:
                if (itemslot5.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot5.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot5.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot5.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot5.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot5.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot5.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 6:
                if (itemslot6.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot6.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot6.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot6.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot6.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot6.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot6.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 7:
                if (itemslot7.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot7.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot7.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot7.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot7.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot7.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot7.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;

            case 8:
                if (itemslot8.RealItemName == "CacaPlanta")
                {
                    Debug.Log("vendi caca planta");

                    current_selected_obj = cacaP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 15;

                }
                else if (itemslot8.RealItemName == "CacaAgua")
                {
                    Debug.Log("incube agua");

                    current_selected_obj = cacaA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 20;

                }
                else if (itemslot8.RealItemName == "CacaFuego")
                {

                    current_selected_obj = cacaF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 35;
                }
                else if (itemslot8.RealItemName == "CacaHielo")
                {

                    current_selected_obj = cacaH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 55;
                }
                else if (itemslot8.RealItemName == "CacaNube")
                {
                    Debug.Log("incube nube");

                    current_selected_obj = cacaN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 60;

                }
                else if (itemslot8.RealItemName == "CacaOro")
                {
                    Debug.Log("incube oro");

                    current_selected_obj = cacaO.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 300;
                }
                else if (itemslot8.RealItemName == "CacaLegendaria")
                {
                    Debug.Log("vendi L");

                    current_selected_obj = cacaL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero += 450;
                }
                else
                {
                    break;
                }
                break;
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

    public void ToggleTienda()
    {



        GameMaster.instanciaCompartida.mostrarTiendaUI = !GameMaster.instanciaCompartida.mostrarTiendaUI;
        tiendaUI.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarTiendaUI);
        
        if (GameMaster.instanciaCompartida.mostrarTiendaUI==true)
        {
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 0f;
        }
        else if(GameMaster.instanciaCompartida.mostrarTiendaUI == false)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
        }

        
    }

    public void ToggleProducto1()
    {
        if(lc==false)
        {
            p1 = !p1;
            producto1.gameObject.SetActive(p1);
            ventanaActiva = 1;
        }
        
    }

    public void ToggleProducto2()
    {
        if (ac == false)
        {
            p2 = !p2;
            producto2.gameObject.SetActive(p2);
            ventanaActiva = 2;
        }
    }

    public void ToggleProducto3()
    {
        if (rc == false)
        {
            p3 = !p3;
            producto3.gameObject.SetActive(p3);
            ventanaActiva = 3;
        }
    }

    public void ToggleProducto4()
    {
        if (afc == false)
        {
            p4 = !p4;
            producto4.gameObject.SetActive(p4);
            ventanaActiva = 4;
        }
    }

    public void ToggleProducto5()
    {
        if (ahc == false)
        {
            p5 = !p5;
            producto5.gameObject.SetActive(p5);
            ventanaActiva = 5;
        }
    }

    public void ToggleProducto6()
    {
        p6 = !p6;
        producto6.gameObject.SetActive(p6);
        ventanaActiva = 6;
    }

    public void Comprar()
    {
        switch(ventanaActiva)
        {
            case 1:

                if(GameMaster.instanciaCompartida.dinero >= 50&&lc==false)
                {
                    current_selected_obj = lanza.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 50;
                    ToggleProducto1();
                    lc = true;
                   
                }
                

                break;

            case 2:

                if (GameMaster.instanciaCompartida.dinero >= 2000 && ac == false)
                {

                    
                    current_selected_obj = arco.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());

                    GameMaster.instanciaCompartida.dinero -= 2000;
                    ToggleProducto2();
                    ac = true;
                }
                break;

            case 3:

                if (GameMaster.instanciaCompartida.dinero >= 400 && rc == false)
                {
                    current_selected_obj = rastrillo.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 400;
                    ToggleProducto3();
                    rc = true;
                }
                break;

            case 4:

                if (GameMaster.instanciaCompartida.dinero >= 8000 && afc == false)
                {
                    current_selected_obj = AF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    if(conexLM.m7c)
                    {
                        GameMaster.instanciaCompartida.dinero -= 1500;
                    }
                    else
                    {
                        GameMaster.instanciaCompartida.dinero -= 8000;
                    }
                    
                    ToggleProducto4();
                    afc = true;
                }
                break;

            case 5:

                if (GameMaster.instanciaCompartida.dinero >= 12000 && ahc == false)
                {
                    current_selected_obj = AH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    if (conexLM.m7c)
                    {
                        GameMaster.instanciaCompartida.dinero -= 2000;
                    }
                    else
                    {
                        GameMaster.instanciaCompartida.dinero -= 12000;
                    }
                    ToggleProducto5();
                    ahc =true;
                }
                break;

            case 6:

                if (GameMaster.instanciaCompartida.dinero >= 10)
                {
                    current_selected_obj = comida.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 10;
                }
                break;
        }
        
    }

}
