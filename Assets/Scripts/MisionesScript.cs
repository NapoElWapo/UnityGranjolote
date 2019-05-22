using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MisionesScript : MonoBehaviour
{
    public Misiones LaMision
    {
        get; set;
    }

    public void Seleccionar()
    {
        GetComponent<Text>().color = Color.cyan;
        LogMisiones.LaInstancia.MostrarDescripcion(LaMision);
    }

    public void Deseleccionar()
    {
        GetComponent<Text>().color = Color.white;
    }
}
