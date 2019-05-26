using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MejorarAjolote : MonoBehaviour
{
    public RectTransform especialA, especialF, especialN, orbeA, orbeF, orbeN, mejorasUI;
    RectTransform espacioAjolote, espacioOrbe;

    public GameObject orbeAwita, orbeFueguito, orbeNubecita;
    public HerramientaSeleccionada ajolotines;

    public bool ajoAI, ajoFI, ajoNI, orbeAI, orbeFI, orbeNI, UIactivo;
    MenuInventario conexMI;
    // Start is called before the first frame update
    void Start()
    {
        conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        ajolotines = GameObject.Find("JugadorUI").GetComponent<HerramientaSeleccionada>();

    }

    // Update is called once per frame
    void Update()
    {
        PuedeMejorar();
    }

    public void MejorarAgua()
    {
        picarMejora();

        foreach (var iterador in conexMI.herramientas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSAgua")
                {
                    ajoAI = true;
                }
            }
        }

        foreach (var iterador in conexMI.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "OrbedeAgua")
                {
                    orbeAI = true;
                }
            }
        }

        //Condicion para ajolote
        if (ajoAI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(true);

        //Condicion para orbe
        if (orbeAI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(3).gameObject.SetActive(true);
    }

    public void MejorarFuego()
    {
        picarMejora();

        foreach (var iterador in conexMI.herramientas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSFuego")
                {
                    ajoFI = true;
                }
            }
        }

        foreach (var iterador in conexMI.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "OrbedeFuego")
                {
                    orbeFI = true;
                }
            }
        }

        //Condicion para ajolote
        if (ajoFI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(true);

        //Condicion para orbe
        if (orbeFI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(4).gameObject.SetActive(true);
    }

    public void MejorarNube()
    {
        picarMejora();

        foreach (var iterador in conexMI.pasivas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSNube")
                {
                    ajoNI = true;
                }
            }
        }

        foreach (var iterador in conexMI.coleccionables)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "OrbedeNube")
                {
                    orbeNI = true;
                }
            }
        }

        //Condicion para ajolote
        if (ajoNI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(2).gameObject.SetActive(true);

        //Condicion para orbe
        if (orbeNI)
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(5).gameObject.SetActive(true);
    }

    void picarMejora()
    {
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(false);
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(2).gameObject.SetActive(false);
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(3).gameObject.SetActive(false);
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(4).gameObject.SetActive(false);
        GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(5).gameObject.SetActive(false);

        ajoAI = false;
        ajoFI = false;
        ajoNI = false;
        orbeAI = false;
        orbeFI = false;
        orbeNI = false;
    }
    public void ToggleMejoras()
    {
        UIactivo = !UIactivo;
        //criaderoUI.gameObject.SetActive(UIactivo);

        if (UIactivo)
        {
            conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
            ajolotines = GameObject.Find("JugadorUI").GetComponent<HerramientaSeleccionada>();

            mejorasUI.gameObject.SetActive(true);

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
            picarMejora();

            mejorasUI.gameObject.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            //Time.timeScale = 1f;
        }
    }

    public void PuedeMejorar()
    {
        if (ajoAI && orbeAI)
        {
            //GameObject.Find("MejorarAjoloteBoton").SetActive(true);
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }

        else if (ajoFI && orbeFI)
        {
            //GameObject.Find("MejorarAjoloteBoton").SetActive(true);
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }

        else if (ajoNI && orbeNI)
        {
            //GameObject.Find("MejorarAjoloteBoton").SetActive(true);
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }
        else
        {
            //GameObject.Find("MejorarAjoloteBoton").SetActive(false);
            this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }
    }

    public void MejorarAjoloteEspecial()
    {
        this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        if (ajoAI && orbeAI)
        {
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(3).gameObject.SetActive(false);
            ajolotines.nivelAgua++;
            GameMaster.instanciaCompartida.inventario.RemoveItem(orbeAwita?.GetComponent<ItemInventario>());
        }

        if (ajoFI && orbeFI)
        {
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(false);
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(4).gameObject.SetActive(false);
            ajolotines.nivelFuego++;
            GameMaster.instanciaCompartida.inventario.RemoveItem(orbeFueguito?.GetComponent<ItemInventario>());
        }

        if (ajoNI && orbeNI)
        {
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(2).gameObject.SetActive(false);
            GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(5).gameObject.SetActive(false);
            ajolotines.nivelNube++;
            GameMaster.instanciaCompartida.inventario.RemoveItem(orbeNubecita?.GetComponent<ItemInventario>());
        }
    }
}
