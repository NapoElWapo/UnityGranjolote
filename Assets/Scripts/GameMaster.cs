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

    //interfaz de incubadora
    public bool mostrarIncubadoraUI = false;
    public bool mostrarIIncubadora=false;
    public bool mostrarAIncubadora = false;
    public bool mostrarIncubadora1 = false;
    public bool mostrarIncubadora2 = false;
    public bool mostrarIncubadora3 = false;
    

    public GameObject Jugador;
    public GameObject Puerta;

    public int dinero=1000;
    
    public int nivelanterior=0;

    public SistemaInventario inventario;
   public MenuInventario GUI_controlador;

    //sistema de reloj + gamemaster
    public int hora=20;
    public float minuto;
    public float horaActual,cambioTotal;
    

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

        VolumenMusica(instanciaCompartida.GetComponent<AudioSource>().volume);
    }

    void OnLevelWasLoaded(int level)
    {

        if (nivelanterior == 3)
        {
            Jugador = GameObject.FindWithTag("Player");
            Puerta = GameObject.FindWithTag("PuertaH");
            Jugador.SetActive(false);
            Jugador.transform.position = Puerta.transform.position;
            Jugador.SetActive(true);
        }
        if (nivelanterior == 4)//si la ultima casa fue la CasaIP hace esto
        {

            Jugador = GameObject.FindWithTag("Player");//encuentra al jugador
            Puerta = GameObject.FindWithTag("Puerta1");//decide de cual puerta salio y agarra su collider
            Jugador.SetActive(false);
            Jugador.transform.position = Puerta.transform.position;//le da la posicion del jugador la misma que el collider
            Jugador.SetActive(true);

        }
        if(nivelanterior == 5)
        {
            Jugador = GameObject.FindWithTag("Player");
            Puerta = GameObject.FindWithTag("Puerta2");
            Jugador.SetActive(false);
            Jugador.transform.position = Puerta.transform.position;
            Jugador.SetActive(true);
        }
        if (nivelanterior == 6)
        {
            Jugador = GameObject.FindWithTag("Player");
            Puerta = GameObject.FindWithTag("PuertaM1");
            Jugador.SetActive(false);
            Jugador.transform.position = Puerta.transform.position;
            Jugador.SetActive(true);
        }
        if (nivelanterior == 7)
        {
            Jugador = GameObject.FindWithTag("Player");
            Puerta = GameObject.FindWithTag("PuertaJ");
            Jugador.SetActive(false);
            Jugador.transform.position = Puerta.transform.position;
            Jugador.SetActive(true);
        }

    }
    public void Jugar()
    {
        SceneManager.LoadScene(NombreEscena.Pruebas);
        Jugador.SetActive(true);
    }

    public void GuardarYSalir()
    {
        SceneManager.LoadScene(NombreEscena.MenuP);
        
    }

    public void Casa1()
    {
        SceneManager.LoadScene(NombreEscena.CasaN);
        
    }

    public void Casa2()
    {
        SceneManager.LoadScene(NombreEscena.CasaN2);
        
    }

    public void CasaMision()
    {
        SceneManager.LoadScene(NombreEscena.CasaM);
        
    }

    public void CasaJugador()
    {
        SceneManager.LoadScene(NombreEscena.CasaJ);
        
    }
    public void CasaHospital()
    {
        SceneManager.LoadScene(NombreEscena.Hospital);
        


    }

    public void VolumenMusica(float newVolumen)
    {
        volumenMusica = newVolumen;
        instanciaCompartida.GetComponent<AudioSource>().volume = volumenMusica;
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
        minuto += Time.deltaTime;

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

}

