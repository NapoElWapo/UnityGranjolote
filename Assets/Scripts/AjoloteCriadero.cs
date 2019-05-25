using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AjoloteCriadero : MonoBehaviour
{
    RectTransform slotActual;
    public RectTransform ajoloteP, ajoloteA, ajoloteF, ajoloteH, ajoloteN, ajoloteD, ajoloteL, nuevoSlot, select1, select2, select3, select4;
    public RectTransform ajoloteActual, doradoTemp, criaderoUI;

    public GameObject botonesCriadero, objetoAct, ajoP, ajoA, ajoF, ajoH, ajoN, ajoD, ajoL;
    slot slot1, slot2, slot3, slot4;

    public Image sslot1, sslot2, sslot3, sslot4;

    MenuInventario inv;
    int slot = 0;
    int slotSeleccionado = 0;
    private bool UIactivo;


    void Start()
    {
        inv = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    void Update()
    {
        slot1 = inv.ajolotes.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = slot1.Slot_ui_img.sprite;

        slot2 = inv.ajolotes.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = slot2.Slot_ui_img.sprite;

        slot3 = inv.ajolotes.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = slot3.Slot_ui_img.sprite;

        slot4 = inv.ajolotes.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = slot4.Slot_ui_img.sprite;
    }

    public void dejarAjolote()
    {
        switch (slotSeleccionado)
        {
            case 1:
                if(slot1.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteDeOro" && ajoloteActual == ajoloteD)
                {
                    ponerAjolote();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot1.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 2:
                if (slot2.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteDeOro" && ajoloteActual == ajoloteD)
                {
                    ponerAjolote();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot2.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 3:
                if (slot3.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteDeOro" && ajoloteActual == ajoloteD)
                {
                    ponerAjolote();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot3.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
                {
                    ponerAjolote();
                    objetoAct = ajoL.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }
                break;

            case 4:
                if (slot4.RealItemName == "AjoloteDePlanta" && ajoloteActual == ajoloteP)
                {
                    ponerAjolote();
                    objetoAct = ajoP.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteDeAgua" && ajoloteActual == ajoloteA)
                {
                    ponerAjolote();
                    objetoAct = ajoA.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteDeFuego" && ajoloteActual == ajoloteF)
                {
                    ponerAjolote();
                    objetoAct = ajoF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteDeHielo" && ajoloteActual == ajoloteH)
                {
                    ponerAjolote();
                    objetoAct = ajoH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteDeNube" && ajoloteActual == ajoloteN)
                {
                    ponerAjolote();
                    objetoAct = ajoN.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteDeOro" && ajoloteActual == ajoloteD)
                {
                    ponerAjolote();
                    objetoAct = ajoD.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.RemoveItem(objetoAct?.GetComponent<ItemInventario>());
                }

                if (slot4.RealItemName == "AjoloteLegendario" && ajoloteActual == ajoloteL)
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
            ajoloteActual= GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>().GetChild(2).gameObject.GetComponent<RectTransform>();

            if (ajoloteActual.name =="PanelAjoloteP(Clone)")
            {
                objetoAct = ajoP.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (ajoloteActual.name == "PanelAjoloteA(Clone)")
            {
                objetoAct = ajoA.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (ajoloteActual.name == "PanelAjoloteF(Clone)")
            {
                objetoAct = ajoF.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (ajoloteActual.name == "PanelAjoloteH(Clone)")
            {
                objetoAct = ajoH.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (ajoloteActual.name == "PanelAjoloteN(Clone)")
            {
                objetoAct = ajoN.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }
            if (ajoloteActual.name == "PanelAjoloteD(Clone)")
            {
                objetoAct = ajoD.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(objetoAct?.GetComponent<ItemInventario>());
                slot++;
                quitarAjolote();
            }

            if (ajoloteActual.name == "PanelAjoloteL(Clone)")
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
        if (slot < 10 && ajoloteActual == ajoloteD)
        {
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
            Instantiate(ajoloteActual, slotActual.transform);
            slot++;
            ajoloteActual = doradoTemp;
        }
        else if (slot < 10 && ajoloteActual != null)
        {
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
            Instantiate(ajoloteActual, slotActual.transform);
            slot++;
            Debug.Log("Se dejo un ajolote");
            if (slot > 0)
                botonesCriadero.gameObject.SetActive(false);
        }
    }

    void quitarAjolote()
    {
        if (slot > 0)
        {
            slot--;
            slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
            Destroy(GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>().GetChild(2).gameObject);
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

    public void CriaderoTipoDorado()
    {
        if (ajoloteActual != ajoloteD)
        {
            doradoTemp = ajoloteActual;
            ajoloteActual = ajoloteD;
        }
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

            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            
            //Time.timeScale = 0f;
        }
        else if (!UIactivo)
        {
            criaderoUI.localPosition = new Vector2(4000f, 4000f);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            //Time.timeScale = 1f;
        }
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
}