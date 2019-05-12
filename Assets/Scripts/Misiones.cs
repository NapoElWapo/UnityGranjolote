using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Misiones
{
    [SerializeField]
    private string titulo;

    [SerializeField]
    private string descripcion;

    public MisionesScript MiMisionesScript { set; get; }

    [SerializeField]
    private AgarrarObjetivos[] agarrarObjetivos;

    public string ElTitulo { get => titulo; set => titulo = value; }
    public string LaDescripcion { get => descripcion; set => descripcion = value; }
    public AgarrarObjetivos[] MiAO { get => agarrarObjetivos;  }
}

[System.Serializable]
public abstract class Objetivo
{
    [SerializeField]
    private int cantidad;

    private int cantidadActual;

    [SerializeField]
    private string tipo;

    public int Cantidad { get => cantidad;  }
    public int LaCantidadActual { get => cantidadActual; set => cantidadActual = value; }
    public string ElTipo { get => tipo;  }
}

[System.Serializable]
public class AgarrarObjetivos : Objetivo
{

}