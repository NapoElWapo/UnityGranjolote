using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInventoryTypeDef;


[System.Serializable]
public class ItemInventario : ItemBase
{
    [SerializeField]
    public ItemCategory Category;


    [SerializeField]
    public float stack_value;
    [Header("Configuracion base")]
    [SerializeField]
    public bool stackeable;

    [SerializeField]
    public int maxStack;



}
