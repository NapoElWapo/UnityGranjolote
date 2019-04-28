using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace ItemInventoryTypeDef
{

    public enum ItemCategory
    {
        none,
        recolectables,
        pasivas,
        herramientas,
        ajolotes
    }


}


[System.Serializable]
public class ItemBase : MonoBehaviour
{
    


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
