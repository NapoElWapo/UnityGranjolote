using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class MenuPrincipal : MonoBehaviour
{
    [System.NonSerialized]
    public RectTransform opcionesPanel;
    [System.NonSerialized]
    public Slider volumenMusicaSlider;
    [System.NonSerialized]
    public Slider volumenEfectosSlider;
    [System.NonSerialized]
    public SaveGameSystem controlador_guardado;

    void Start()
    {
        volumenMusicaSlider.value = GameMaster.instanciaCompartida.volumenMusica;
        volumenEfectosSlider.value = GameMaster.instanciaCompartida.volumenEfectos;
    }

    public void cargarUltimaPartida()
    {
        GameObject.FindObjectOfType<SaveGameSystem>().loadGame = true;
        GameMaster.instanciaCompartida.Jugar();
    }


    
   
    //Esta de aqui se encarga de hacer el nuevo juego
    public void jugar()
    {
        //controlador_guardado.LoadGame(true);
        GameObject.FindObjectOfType<SaveGameSystem>().loadGame = false;
        GameMaster.instanciaCompartida.Jugar();
    }

    public void opciones()
    {
        ToggleOpciones();
    }

    public void salir()
    {
        Application.Quit();
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
        Cursor.lockState = CursorLockMode.None; //Locks the mouse
        Cursor.visible = true; // Make the cursor visable
    }
}
