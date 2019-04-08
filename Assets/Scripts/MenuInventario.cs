using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using System;



[Serializable]
public class slot
{
    public string slot_name;
    public Text slot_stack;
    public Image slot_ui_img;

}


public class MenuInventario : MonoBehaviour
{
    public RectTransform mochila, ajolotepedia, logrosMisiones, mapa;
    public static bool menuCerrado = false;
    public GameObject inventario_ui;

    //Estas son las preterminadas configuradas en el editor (cambiar esto para beneficio muto)
    public slot[] ajolotes, coleccionables, herramientas, pasivas;







    //Clases para cada tipo de botones del inventario -añadidos




    private void Start()
    {
        GameMaster.instanciaCompartida.SetUI(this);
    }



    void Update()
    {
        if (Input.GetButtonDown("i"))
        {

            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            GameMaster.instanciaCompartida.mostrarMochila = true;
            GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
            GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
            GameMaster.instanciaCompartida.mostrarMapa = false;
            mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
            mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
            ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
            logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);


            if (menuCerrado)
            {

                var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
                var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
                mouseLook.XSensitivity = 2F;
                mouseLook.YSensitivity = 2F;
                ToggleInventario();
                inventario_ui.SetActive(false);
                Time.timeScale = 1f;
                menuCerrado = false;
            }
            else
            {

                var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
                var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
                mouseLook.XSensitivity = 0.0F;
                mouseLook.YSensitivity = 0.0F;
                inventario_ui.SetActive(true);
                Time.timeScale = 0f;
                menuCerrado = true;
            }

        }
    }

    public void Inventario()
    {

        ToggleInventario();


    }

    public void Mochila()
    {

        GameMaster.instanciaCompartida.mostrarMochila = true;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void Ajolotepedia()
    {

        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = true;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void LogrosMisiones()
    {

        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = true;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void Mapa()
    {

        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = true;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void ToggleInventario()
    {



        GameMaster.instanciaCompartida.mostrarInventario = !GameMaster.instanciaCompartida.mostrarInventario;
        inventario_ui.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarInventario);

    }





    public void actualizar_recolectables(ItemInventario last_entry)
    {

        Debug.Log("UI ITEMS REFRESHED");

        foreach (var iterador_ui_coleccionables in coleccionables)
        {
            if (iterador_ui_coleccionables.slot_name == "Slot1" && last_entry.name == "OrbeFuego") // el slot 1 de la UI sera para coleccionables de tipo orbe por ejemplo
            {
                iterador_ui_coleccionables.slot_ui_img.overrideSprite = last_entry.inventory_decal;
                iterador_ui_coleccionables.slot_stack.text = GameMaster.instanciaCompartida.inventario.recolectables.Count.ToString();
            }
        }
    }



    public void actualizar_herramientas(ItemInventario last_entry)
    {

    }



    public void actualizar_pasivas(ItemInventario last_entry)
    {
    }


    public void actualizar_ajolotes(ItemInventario last_entry)
    {



        foreach (var iterador_ui_ajolotes in ajolotes)
        {

        }
    }

}
