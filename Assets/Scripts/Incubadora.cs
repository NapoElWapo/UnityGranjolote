using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Incubadora : MonoBehaviour
{
    public RectTransform items, ajolotesincu, incubadora1, incubadora2, incubadora3, incubadoraUI;
    slot itemslot1, itemslot2, itemslot3, itemslot4,itemslot5,itemslot6,itemslot7,itemslot8;
    public Image sslot1, sslot2, sslot3, sslot4,sslot5,sslot6,sslot7,sslot8;
    public RectTransform bslot1, bslot2, bslot3, bslot4,bslot5,bslot6,bslot7,bgslot8;
    private int slotSeleccionado=0;
    MenuInventario conex;

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

        itemslot5 = conex.coleccionables.Find(x => x.Slot_name == "Slot1");
        sslot5.sprite = itemslot5.Slot_ui_img.sprite;

        itemslot6 = conex.coleccionables.Find(x => x.Slot_name == "Slot2");
        sslot6.sprite = itemslot6.Slot_ui_img.sprite;

        itemslot7 = conex.coleccionables.Find(x => x.Slot_name == "Slot3");
        sslot7.sprite = itemslot7.Slot_ui_img.sprite;

        itemslot8 = conex.coleccionables.Find(x => x.Slot_name == "Slot4");
        sslot8.sprite = itemslot8.Slot_ui_img.sprite;
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
