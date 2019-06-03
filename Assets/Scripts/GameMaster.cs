using System.Collections;
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
[System.Serializable]
[RequireComponent(typeof(AudioSource))]
public class GameMaster : MonoBehaviour
{
    [System.NonSerialized]
    public static GameMaster instanciaCompartida;
    [System.NonSerialized]
    public float volumenMusica = 0, volumenEfectos = 0;
    [System.NonSerialized]

    public bool mostrarOpciones = false;
    [System.NonSerialized]
    public bool mostrarInventario = false;
    [System.NonSerialized]
    public bool mostrarMochila = false;
    [System.NonSerialized]
    public bool mostrarAjolotepedia = false;
    [System.NonSerialized]
    public bool mostrarLogrosMisiones = false;
    [System.NonSerialized]
    public bool mostrarMapa = false;
    [System.NonSerialized]
    public bool mostrarIncubadoraUI = false;
    [System.NonSerialized]
    public bool mostrarIIncubadora = false;
    [System.NonSerialized]
    public bool mostrarAIncubadora = false;
    [System.NonSerialized]
    public bool mostrarIncubadora1 = false;
    [System.NonSerialized]
    public bool mostrarIncubadora2 = false;
    [System.NonSerialized]
    public bool mostrarIncubadora3 = false;
    [System.NonSerialized]
    public bool mostrarTiendaUI = false;

    public int hora = 12;
    public float minuto;
    public float horaActual, cambioTotal;
    [System.NonSerialized]
    public GameObject Jugador;
    [System.NonSerialized]
    public GameObject Puerta;
    [System.NonSerialized]
    public AudioSource MusicManager;
    public int dinero = 1000;

    [System.NonSerialized]
    public int nivelanterior=0;
   
    public SistemaInventario inventario;
    public MenuInventario GUI_controlador;
    [System.NonSerialized]
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
