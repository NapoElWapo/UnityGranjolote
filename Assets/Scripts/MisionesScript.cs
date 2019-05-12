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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
