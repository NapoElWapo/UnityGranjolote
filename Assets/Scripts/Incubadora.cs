using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Incubadora : MonoBehaviour
{

    public RectTransform items, ajolotes, incubadora1, incubadora2, incubadora3,incubadoraUI;
    public void BotonIItems()
    {

        GameMaster.instanciaCompartida.mostrarAIncubadora = true;
        GameMaster.instanciaCompartida.mostrarIIncubadora = false;
        
        items.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAIncubadora);
        ajolotes.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIIncubadora);
        
    }
    public void BotonAItems()
    {

        GameMaster.instanciaCompartida.mostrarAIncubadora = false;
        GameMaster.instanciaCompartida.mostrarIIncubadora = true;

        items.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAIncubadora);
        ajolotes.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIIncubadora);

    }

    public void Incubadora1()
    {
        Debug.Log("Si entra");
        GameMaster.instanciaCompartida.mostrarIncubadora1 = true;
        GameMaster.instanciaCompartida.mostrarIncubadora2 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora3 = false;

        incubadora1.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora1);
        incubadora2.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora2);
        incubadora3.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora3);



    }

    public void Incubadora2()
    {

        GameMaster.instanciaCompartida.mostrarIncubadora1 = false;
        GameMaster.instanciaCompartida.mostrarIncubadora2 = true;
        GameMaster.instanciaCompartida.mostrarIncubadora3 = false;

        incubadora1.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora1);
        incubadora2.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora2);
        incubadora3.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarIncubadora3);



    }

    public void Incubadora3()
    {

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

    }

    void Update()
    {
        if(GameMaster.instanciaCompartida.mostrarIncubadoraUI==false)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;

        }
        else if(GameMaster.instanciaCompartida.mostrarIncubadoraUI == true)
        {
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 0f;
        }
    }
}
