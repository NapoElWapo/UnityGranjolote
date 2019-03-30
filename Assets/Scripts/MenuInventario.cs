using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInventario : MonoBehaviour
{
    public RectTransform inventario,ajolotepedia,logrosMisiones,mapa;
   

    public void Inventario()
    {
        ToggleInventario();
    }

    public void Ajolotepedia()
    {
        ToggleAjolotepedia();
    }

    public void LogrosMisiones()
    {
        ToggleLogrosMisiones();
    }

    public void Mapa()
    {
        ToggleMapa();
    }

    public void ToggleInventario()
    {
        GameMaster.instanciaCompartida.mostrarInventario = !GameMaster.instanciaCompartida.mostrarInventario;
        inventario.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarInventario);
    }

    public void ToggleAjolotepedia()
    {
        GameMaster.instanciaCompartida.mostrarAjolotepedia = !GameMaster.instanciaCompartida.mostrarAjolotepedia;
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
    }

    public void ToggleLogrosMisiones()
    {
        GameMaster.instanciaCompartida.mostrarOpciones = !GameMaster.instanciaCompartida.mostrarOpciones;
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarOpciones);
    }

    public void ToggleMapa()
    {
        GameMaster.instanciaCompartida.mostrarOpciones = !GameMaster.instanciaCompartida.mostrarOpciones;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarOpciones);
    }
}
