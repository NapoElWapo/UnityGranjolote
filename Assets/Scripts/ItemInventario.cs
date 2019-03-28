using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInventario : ItemBase
{
    [SerializeField]
    private ItemCategory category;

    [SerializeField]
    private float valor;

    public ItemCategory Category
    {
        get { return category; }
        set { category = value; }

    }

    public float Valor
    {
        get { return valor; }
        set { valor = value; }

    }
}
