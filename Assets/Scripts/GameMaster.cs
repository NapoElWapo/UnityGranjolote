using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class NombreEscena
{
    public const string Mundo = "OverWorld";
    public const string Hospital = "Hospital";
    public const string CasaN = "CasaNormal";
    public const string CasaM = "CasaMision";
    public const string CasaJ = "CasaJugador";
    public const string Pruebas = "Pruebas";
}

[RequireComponent(typeof(AudioSource))]
public class GameMaster : MonoBehaviour
{
    public static GameMaster instanciaCompartida;
    public float volumenMusica = 0, volumenEfectos = 0;
    public bool mostrarOpciones = false;
    public bool mostrarInventario = false;
    public bool mostrarAjolotepedia = false;
    public bool mostrarLogrosMisiones = false;
    public bool mostrarMapa = false;

    public SistemaInventario inventario;

    // Start is called before the first frame update

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

    public void Jugar()
    {
        SceneManager.LoadScene(NombreEscena.Pruebas);
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
