using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogMisiones : MonoBehaviour
{
    [SerializeField]
    private GameObject misionPrefab;

    [SerializeField]
    private Transform listaMision;

    [SerializeField]
    private Text descripcionM;

    private Misiones seleccionada;

    private static LogMisiones instancia;

    public static LogMisiones LaInstancia
    {
        get
        {
            if (instancia == null)
            {
                instancia = FindObjectOfType<LogMisiones>();
            }
            return instancia;
        }
    }

    

    public void AceptarMision(Misiones misiones)
    {
        GameObject go = Instantiate(misionPrefab,listaMision);
        go.GetComponent<Text>().text = misiones.ElTitulo;

        MisionesScript ms = go.GetComponent<MisionesScript>();
        ms.LaMision = misiones;
        misiones.MiMisionesScript = ms;
    }

    public void MostrarDescripcion(Misiones misiones)
    {
        if (misiones != null)
        {
            if (seleccionada != null && seleccionada != misiones)
            {
                seleccionada.MiMisionesScript.Deseleccionar();
            }

            string objetivos = string.Empty;

            foreach (Objetivo obj in misiones.MiAO)
            {
                objetivos += obj.ElTipo + ": " + obj.LaCantidadActual + "/" + obj.Cantidad + "\n";
            }

            seleccionada = misiones;

            string titulo = misiones.ElTitulo;
            descripcionM.text = string.Format("{0}\n\n<size=12>{1}</size>\n\nObjetivos\n<size=12>{2}</size>", titulo, misiones.LaDescripcion, objetivos);
        }
    }
}
