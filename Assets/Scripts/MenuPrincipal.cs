﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuPrincipal : MonoBehaviour
{
    public RectTransform opcionesPanel;
    public Slider volumenMusicaSlider;
    public Slider volumenEfectosSlider;

    void Start()
    {
        volumenMusicaSlider.value = GameMaster.instanciaCompartida.volumenMusica;
        volumenEfectosSlider.value = GameMaster.instanciaCompartida.volumenEfectos;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void jugar()
    {
        GameMaster.instanciaCompartida.Jugar();
    }

    public void opciones()
    {
        ToggleOpciones();
    }

    public void salir()
    {

    }

    public void salirOpciones()
    {
        ToggleOpciones();
    }

    public void VolumenMusica()
    {
        GameMaster.instanciaCompartida.VolumenMusica(volumenMusicaSlider.value);
    }
    public void VolumenEfectos()
    {
        GameMaster.instanciaCompartida.VolumenMusica(volumenEfectosSlider.value);

    }

    public void ToggleOpciones()
    {
        GameMaster.instanciaCompartida.mostrarOpciones = !GameMaster.instanciaCompartida.mostrarOpciones;
        opcionesPanel.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarOpciones);
    }
    
}