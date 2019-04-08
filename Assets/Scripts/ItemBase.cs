using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemBase : MonoBehaviour
{
    public enum ItemCategory
    {
        recolectables,
        pasivas,
        herramientas,
        ajolotes
    }




    public Sprite inventory_decal;

    [SerializeField]
    private string name;

    [SerializeField]
    private string descripcion;



    
    

    public string Name
    {
        get { return name; }
        set { name = value; }

    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }

    }

   
}
