using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarMision : MonoBehaviour
{
    [SerializeField]
    private Misiones[] misiones;
    //Esto nomas es para ver el funcionamiento de los componentes de misiones y eso,
    //Eliminar cuando los NPCs te puedan dar misiones

        [SerializeField]
    private LogMisiones tmplog;

    private void Awake()
    {
        tmplog.AceptarMision(misiones[0]);
        tmplog.AceptarMision(misiones[1]);
        tmplog.AceptarMision(misiones[2]);
    }
}
