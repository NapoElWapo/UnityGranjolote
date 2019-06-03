using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AjoloteCriadero : MonoBehaviour
{
    RectTransform slotActual;
    public RectTransform slotHuevo, ajoloteP, ajoloteA, ajoloteF, ajoloteH, ajoloteN, ajoloteD, ajoloteL, huevoP, huevoA, huevoF, huevoH, huevoN, huevoD, huevoActual, nuevoSlot, select1, select2, select3, select4;
    public RectTransform ajoloteActual, checarAjolote, checarHuevo, doradoTemp, criaderoUI, itemsUI, ajolotesUI, recogerHuevoBoton, comprarCriaderoPanel;

    public GameObject botonesCriadero, objetoAct, ajoP, ajoA, ajoF, ajoH, ajoN, ajoD, ajoL, hueP, hueA, hueF, hueH, hueN, hueD, lataComida, pezComida, gusanoComida;
    slot Aslot1, Aslot2, Aslot3, Aslot4, itemslot1, itemslot2, itemslot3, itemslot4, itemslot5, itemslot6, itemslot7, itemslot8;

    public Image sAslot1, sAslot2, sAslot3, sAslot4, sslot1, sslot2, sslot3, sslot4, sslot5, sslot6, sslot7, sslot8;

    

    MenuInventario inv;
    AjoloteDesecho ajoDes;
    LogrosYMisiones conexLM;

    int slot = 0;
    int slotComida = 0;
    int slotSeleccionado = 0;
    public int cantidadAjolotesFelices;
    public int numeroCriadero;
    public bool UIactivo, hayDorado, checarUnaVez;
    public int dejarHuevo, porcentajeHuevo = 30, dejarHuevoDorado, porcentajeHuevoDorado = 10;
    public int precioCriadero;
    public bool criaderoLleno;
    public int criaderollenito = 0;
    void Start()
    {
        inv = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
    }

    void Update()
    {
        Aslot1 = inv.ajolotes.Find(x => x.Slot_name == "Slot1");
        sAslot1.sprite = Aslot1.Slot_ui_img.sprite;

        Aslot2 = inv.ajolotes.Find(x => x.Slot_name == "Slot2");
        sAslot2.sprite = Aslot2.Slot_ui_img.sprite;

        Aslot3 = inv.ajolotes.Find(x => x.Slot_name == "Slot3");
        sAslot3.sprite = Aslot3.Slot_ui_img.sprite;

        Aslot4 = inv.ajolotes.Find(x => x.Slot_name == "Slot4");
        sAslot4.sprite = Aslot4.Slot_ui_img.sprite;

        itemslot1 = inv.coleccionables.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = itemslot1.Slot_ui_img.sprite;

        itemslot2 = inv.coleccionables.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = itemslot2.Slot_ui_img.sprite;

        itemslot3 = inv.coleccionables.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = itemslot3.Slot_ui_img.sprite;

        itemslot4 = inv.coleccionables.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = itemslot4.Slot_ui_img.sprite;

        itemslot5 = inv.coleccionables.Find(x => x.Slot_name == "Slot5");
        sslot5.sprite = itemslot5.Slot_ui_img.sprite;

        itemslot6 = inv.coleccionables.Find(x => x.Slot_name == "Slot6");
        sslot6.sprite = itemslot6.Slot_ui_img.sprite;

        itemslot7 = inv.coleccionables.Find(x => x.Slot_name == "Slot7");
        sslot7.sprite = itemslot7.Slot_ui_img.sprite;

        itemslot8 = inv.coleccionables.Find(x => x.Slot_name == "Slot8");
        sslot8.sprite = itemslot8.Slot_ui_img.sprite;

        checarReloj();

        if(slot==10)
        {
            criaderoLleno = true;
            criaderollenito = 1;
        }
        else if(slot<10)
        {
            criaderollenito = 0;
            criaderoLleno = false;

        }

    }

    public void dejarAjolote()
    {
        switch (slotSeleccionado)
        {
            case 1:
                if(Aslot1.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteDeOro")
                {
                    ponerAjoloteDorado();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot1.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 2:
                if (Aslot2.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteDeOro")
                {
                    ponerAjoloteDorado();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot2.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 3:
                if (Aslot3.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteDeOro")
                {
                    ponerAjoloteDorado();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot3.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 4:
                if (Aslot4.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteDeOro")
                {
                    ponerAjoloteDorado();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (Aslot4.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            default:
                break;
        }
        //ponerAjolote();
    }

    public void recogerAjolote()
    {
        if(slot>0)
        {
            slot--;
            checarAjolote = GameObject.Find("AjoloteSlotC (" + slot + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<RectTransform>();

            if (checarAjolote.name =="PanelAjoloteP(Clone)")
            {
                objetoAct = ajoP.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (checarAjolote.name == "PanelAjoloteA(Clone)")
            {
                objetoAct = ajoA.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (checarAjolote.name == "PanelAjoloteF(Clone)")
            {
                objetoAct = ajoF.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (checarAjolote.name == "PanelAjoloteH(Clone)")
            {
                objetoAct = ajoH.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (checarAjolote.name == "PanelAjoloteN(Clone)")
            {
                objetoAct = ajoN.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }
            if (checarAjolote.name == "PanelAjoloteD(Clone)")
            {
                objetoAct = ajoD.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (checarAjolote.name == "PanelAjoloteL(Clone)")
            {
                objetoAct = ajoL.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }
        }
        
    }

    void ponerAjolote()
    {
        if (slot < 10 && ajoloteActual != null)
        {
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ") C" + numeroCriadero).GetComponent<RectTransform>();
            Instantiate(ajoloteActual, slotActual.transform);
            slot++;
            Debug.Log("Se dejo un ajolote");
            if (slot > 0)
                botonesCriadero.gameObject.SetActive(false);
        }
    }

    void ponerAjoloteDorado()
    {
        doradoTemp = ajoloteActual;
        ajoloteActual = ajoloteD;
        if (slot < 10)
        {
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ") C" + numeroCriadero).GetComponent<RectTransform>();
            Instantiate(ajoloteActual, slotActual.transform);
            slot++;
        }
        ajoloteActual = doradoTemp;
    }



    void quitarAjolote()
    {
        if (slot > 0)
        {
            slot--;
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ") C" + numeroCriadero).GetComponent<RectTransform>();
            Destroy(GameObject.Find("AjoloteSlotC (" + slot + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject);
        }

        if (slot == 0)
        {
            botonesCriadero.gameObject.SetActive(true);
            ajoloteActual = null;
        }
    }

    public void CriaderoTipoPlanta()
    {
        ajoloteActual = ajoloteP;
    }

    public void CriaderoTipoAgua()
    {
        ajoloteActual = ajoloteA;
    }

    public void CriaderoTipoFuego()
    {
        ajoloteActual = ajoloteF;
    }

    public void CriaderoTipoHielo()
    {
        ajoloteActual = ajoloteH;
    }

    public void CriaderoTipoNube()
    {
        ajoloteActual = ajoloteN;
    }

    public void CriaderoTipoLegendario()
    {
        ajoloteActual = ajoloteL;
    }

    public void ToggleCriadero()
    {
        UIactivo = !UIactivo;
        //criaderoUI.gameObject.SetActive(UIactivo);

        if (UIactivo)
        {
            criaderoUI.localPosition = new Vector2(0f, 0f);
            //criaderoUI.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed = 0f;
            var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = 0f;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            
            //Time.timeScale = 0f;
        }
        else if (!UIactivo)
        {
            criaderoUI.localPosition = new Vector2(1000f, 1000f);
            //criaderoUI.gameObject.SetActive(false);

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed = 15f;
            var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = 30f;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            //Time.timeScale = 1f;
        }
    }

    public void ComprarCriadero()
    {
        if(GameMaster.instanciaCompartida.dinero >= precioCriadero)
        {
            conexLM.criaderosComprados += 1;
            GameMaster.instanciaCompartida.dinero -= precioCriadero;
            comprarCriaderoPanel.gameObject.SetActive(false);
        }
    }

    public void MostrarItems()
    {
        itemsUI.gameObject.SetActive(true);
        ajolotesUI.gameObject.SetActive(false);
    }

    public void MostrarAjolotes()
    {
        itemsUI.gameObject.SetActive(false);
        ajolotesUI.gameObject.SetActive(true);
    }

    public void Seleccionar1()
    {
        slotSeleccionado = 1;
        select1.gameObject.SetActive(true);
        select2.gameObject.SetActive(false);
        select3.gameObject.SetActive(false);
        select4.gameObject.SetActive(false);
    }

    public void Seleccionar2()
    {
        slotSeleccionado = 2;
        select1.gameObject.SetActive(false);
        select2.gameObject.SetActive(true);
        select3.gameObject.SetActive(false);
        select4.gameObject.SetActive(false);
    }

    public void Seleccionar3()
    {
        slotSeleccionado = 3;
        select1.gameObject.SetActive(false);
        select2.gameObject.SetActive(false);
        select3.gameObject.SetActive(true);
        select4.gameObject.SetActive(false);
    }

    public void Seleccionar4()
    {
        slotSeleccionado = 4;
        select1.gameObject.SetActive(false);
        select2.gameObject.SetActive(false);
        select3.gameObject.SetActive(false);
        select4.gameObject.SetActive(true);
    }

    public void AlimentarLata()
    {
        foreach (var iterador in inv.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "ComidaGenerica")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        ajoDes = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<AjoloteDesecho>();
                        if (!ajoDes.alimentado)
                        {
                            ajoDes.timerkk = ajoDes.timerkk * 0.83f;
                            ajoDes.tiempoVar = ajoDes.tiempoDesecho * 0.83f;
                            ajoDes.alimentado = true;
                            ajoDes.feliz = true;
                            objetoAct = lataComida;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                            break;
                        }
                    }
                }
            }
        }
    }

    public void AlimentarPez()
    {

        foreach (var iterador in inv.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "Pescado")
                {
                    conexLM.alimenteAjolote = true;
                    for (int i = 0; i < 10; i++)
                    {
                        ajoDes = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<AjoloteDesecho>();
                        if (!ajoDes.alimentado)
                        {
                            ajoDes.timerkk = ajoDes.timerkk * 0.66f;
                            ajoDes.tiempoVar = ajoDes.tiempoDesecho * 0.66f;
                            ajoDes.alimentado = true;
                            ajoDes.muyFeliz = true;
                            objetoAct = pezComida;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                            break;
                        }
                    }
                }
            }
        }
        
    }

    public void AlimentarGusano()
    {
        foreach (var iterador in inv.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "Gusano")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        ajoDes = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<AjoloteDesecho>();
                        if (!ajoDes.alimentado)
                        {
                            ajoDes.timerkk = ajoDes.timerkk - (ajoDes.tiempoDesecho/10);
                            objetoAct = gusanoComida;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                            break;
                        }

                    }
                }
            }
        }
    }

    void checarReloj()
    {
        if (GameMaster.instanciaCompartida.hora == 23 && GameMaster.instanciaCompartida.minuto >= 57 && GameMaster.instanciaCompartida.hora == 23 && GameMaster.instanciaCompartida.minuto <= 58 && !checarUnaVez)
            checarUnaVez = true;

        else if (GameMaster.instanciaCompartida.hora == 23 && GameMaster.instanciaCompartida.minuto >= 58 && checarUnaVez)
        {
            checarUnaVez = false;
            for (int i = 0; i < 10; i++)
            {
                ajoDes = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<AjoloteDesecho>();
                if (ajoDes.muyFeliz)
                {
                    cantidadAjolotesFelices++;
                }
                checarAjolote = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<RectTransform>();
                if (checarAjolote.name == "PanelAjoloteD(Clone)")
                {
                    hayDorado = true;
                }
            }
            
        }

        else if (cantidadAjolotesFelices >= 2)
            ponerHuevo();

    }

    void ponerHuevo()
    {
        if(hayDorado)
            dejarHuevoDorado = Random.Range(1, 100);

        if (!hayDorado)
            dejarHuevoDorado = 100;

        slotHuevo = GameObject.Find("HuevoSlot C" + numeroCriadero).GetComponent<RectTransform>();
        dejarHuevo = Random.Range(1, 100);

        if (dejarHuevo <= porcentajeHuevo)
        {
            if (dejarHuevoDorado <= porcentajeHuevoDorado)
            {
                Instantiate(huevoD, slotHuevo.transform);
                recogerHuevoBoton.gameObject.SetActive(true);
            }

            else
            {
                for (int i = 0; i < 10; i++)
                {
                    checarAjolote = GameObject.Find("AjoloteSlotC (" + i + ") C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<RectTransform>();

                    if (checarAjolote.name == "PanelAjoloteP(Clone)")
                    {
                        huevoActual = huevoP;
                        recogerHuevoBoton.gameObject.SetActive(true);
                        break;
                    }

                    if (checarAjolote.name == "PanelAjoloteA(Clone)")
                    {
                        huevoActual = huevoA;
                        recogerHuevoBoton.gameObject.SetActive(true);
                        break;
                    }

                    if (checarAjolote.name == "PanelAjoloteF(Clone)")
                    {
                        huevoActual = huevoF;
                        recogerHuevoBoton.gameObject.SetActive(true);
                        break;
                    }

                    if (checarAjolote.name == "PanelAjoloteH(Clone)")
                    {
                        huevoActual = huevoH;
                        recogerHuevoBoton.gameObject.SetActive(true);
                        break;
                    }

                    if (checarAjolote.name == "PanelAjoloteN(Clone)")
                    {
                        huevoActual = huevoN;
                        recogerHuevoBoton.gameObject.SetActive(true);
                        break;
                    }
                }
                Instantiate(huevoActual, slotHuevo.transform);
                
            }
        }
        cantidadAjolotesFelices = 0;
        hayDorado = false;
    }

    public void RecogerHuevo()
    {
        checarHuevo = GameObject.Find("HuevoSlot C" + numeroCriadero).GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<RectTransform>();

        if (checarHuevo.name == "PanelHuevoP(Clone)")
        {
            objetoAct = hueP.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        if (checarHuevo.name == "PanelHuevoA(Clone)")
        {
            objetoAct = hueA.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        if (checarHuevo.name == "PanelHuevoF(Clone)")
        {
            objetoAct = hueF.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        if (checarHuevo.name == "PanelHuevoH(Clone)")
        {
            objetoAct = hueH.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        if (checarHuevo.name == "PanelHuevoN(Clone)")
        {
            objetoAct = hueN.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        if (checarHuevo.name == "PanelHuevoD(Clone)")
        {
            objetoAct = hueD.transform.gameObject;
            GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
        }

        Destroy(checarHuevo.gameObject);
        recogerHuevoBoton.gameObject.SetActive(false);
    }
}
