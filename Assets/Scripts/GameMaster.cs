﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class NombreEscena
{
    public const string Mundo = "OverWorld";
    public const string Hospital = "Hospital";
    public const string CasaN = "CasaIP";
    public const string CasaN2 = "CasaIP1";
    public const string CasaM = "CasaIPM";
    public const string CasaJ = "CasaIJ";
    public const string Pruebas = "Pruebas";
    public const string MenuP = "MenuPrincipal";
    public const string PA = "PruebasAceves";
    public const string PN = "PruebasNapo";
    public const string PL = "PruebasLuisFer";
}

[RequireComponent(typeof(AudioSource))]
public class GameMaster : MonoBehaviour
{
    public static GameMaster instanciaCompartida;
    public float volumenMusica = 0, volumenEfectos = 0;
    public bool mostrarOpciones = false;
    public bool mostrarInventario = false;
    public bool mostrarMochila = false;
    public bool mostrarAjolotepedia = false;
    public bool mostrarLogrosMisiones = false;
    public bool mostrarMapa = false;

    public bool mostrarIncubadoraUI = false;
    public bool mostrarIIncubadora = false;
    public bool mostrarAIncubadora = false;
    public bool mostrarIncubadora1 = false;
    public bool mostrarIncubadora2 = false;
    public bool mostrarIncubadora3 = false;

    public bool mostrarTiendaUI = false;

    public int hora = 12;
    public float minuto;
    public float horaActual, cambioTotal;

    public GameObject Jugador;
    public GameObject Puerta;
    public AudioSource MusicManager;
    public int dinero = 1000;
    
    public int nivelanterior=0;

    public SistemaInventario inventario;
    public MenuInventario GUI_controlador;

    public float cambioVelocidad=1f;

    private void Awake()
    {

        if(instanciaCompartida==null)
        {
            instanciaCompartida = this;
            inventario = new SistemaInventario();
        }
        else if(instanciaCompartida!=this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);

        MusicManager = GetComponent<AudioSource>();
        //VolumenMusica(instanciaCompartida.GetComponent<AudioSource>().volume);
        VolumenMusica(MusicManager.volume);
    }

   
    public void Jugar()
    {
        SceneManager.LoadScene(NombreEscena.Mundo);//cambiar dependiendo a que escena quieres ir al darle jugar
    }

    public void GuardarYSalir()
    {
        SceneManager.LoadScene(NombreEscena.MenuP);
    }

    

    public void VolumenMusica(float newVolumen)
    {
        volumenMusica = newVolumen;
        //instanciaCompartida.GetComponent<AudioSource>().volume = volumenMusica;
        MusicManager.volume = volumenMusica;
    }

    public void VolumenEfectos(float newVolumen)
    {
        volumenEfectos = newVolumen;
    }

   public void SetUI(MenuInventario other)
    {
        GUI_controlador = other;
    }

    void Update()
    {
        minuto += Time.deltaTime*cambioVelocidad;

        if (minuto >= 60)
        {
            hora = hora + 1;
            minuto = 0;
        }

        if (hora > 23)
        {
            hora = 0;
        }

        horaActual = (hora * 60) + minuto;
    }

    public void CambiarMusica(AudioClip musica)
    {
        if (MusicManager.clip.name == musica.name)
            return;
        MusicManager.Stop();
        MusicManager.clip = musica;
        MusicManager.Play();
    }
}
