using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInventoryTypeDef;
using System;

[System.Serializable]
public class ItemInventario :MonoBehaviour, IEquatable<ItemInventario>
{
    [Header("Configuracion del item")]
    public Sprite Inventory_Decal;
    [SerializeField]
    public string Nombre;
    [SerializeField]
    public string Descripcion;
    [SerializeField]
    public ItemCategory Category;
    [Header("Configuracion del contenido")]
    [SerializeField]
    public uint Stack_value=1;
    [SerializeField]
    public bool Stackeble;
    [SerializeField]
    public int MaxStack;
   

    public bool Equals(ItemInventario other)
    {
       return this.Nombre.Contains(other.Nombre);
    }
}
