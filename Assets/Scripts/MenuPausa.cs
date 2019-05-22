using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MenuPausa : MonoBehaviour
{  
    public static bool juegoPausado = false;
    public RectTransform opcionesPanel;
    public GameObject menuPausaUI;
    public Slider volumenMusicaSlider;
    public Slider volumenEfectosSlider;

    void Start()
    {
        volumenMusicaSlider.value = GameMaster.instanciaCompartida.volumenMusica;
        volumenEfectosSlider.value = GameMaster.instanciaCompartida.volumenEfectos;
    }

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (Cursor.visible == false)
            {
                Cursor.lockState = CursorLockMode.None;           
                Cursor.visible = true;
                if (juegoPausado)
                {
                    Renaudar();
                }
                else
                {
                    Pausa();
                }
            }
        }
    }

    public void VolumenMusica()
    {
        GameMaster.instanciaCompartida.VolumenMusica(volumenMusicaSlider.value);
    }

    public void VolumenEfectos()
    {
        GameMaster.instanciaCompartida.VolumenMusica(volumenEfectosSlider.value);
    }

    public void Renaudar()
    {
        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
        menuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        juegoPausado = false;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 2F;
        mouseLook.YSensitivity = 2F;
    }

    public void GuardarYSalir()
    {
        GameMaster.instanciaCompartida.GuardarYSalir();   
    }

    void Pausa()
    {
        var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
        menuPausaUI.SetActive(true);
        Time.timeScale = 0.0f;
        juegoPausado = true;
        var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
        mouseLook.XSensitivity = 0.0F;
        mouseLook.YSensitivity = 0.0F;
    }

    public void opciones()
    {
        ToggleOpciones();
    }

    public void salirOpciones()
    {
        ToggleOpciones();
    }

    public void ToggleOpciones()
    {
        GameMaster.instanciaCompartida.mostrarOpciones = !GameMaster.instanciaCompartida.mostrarOpciones;
        opcionesPanel.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarOpciones);       
    }
}
