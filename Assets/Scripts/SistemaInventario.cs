using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SistemaInventario 
{
    [SerializeField]
    private List<ItemInventario> desechos = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> trajes = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> orbes = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> herramientas = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> comida = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> ajolotes = new List<ItemInventario>();



    private ItemInventario selectHerramienta;
    private ItemInventario selectTraje;

    public ItemInventario SelectHerramienta
    {
        get { return selectHerramienta; }
        set { selectHerramienta = value; }

    }

    public ItemInventario SelectTraje
    {
        get { return selectTraje; }
        set { selectTraje = value; }

    }

    public SistemaInventario()
    {
        desechos.Clear();
        trajes.Clear();
        orbes.Clear();
        herramientas.Clear();
        comida.Clear();
        ajolotes.Clear();

    }

    public void AddItem(ItemInventario item)
    {
        switch(item.Category)
        {
            case ItemBase.ItemCategory.ajolotes:
                ajolotes.Add(item);
                break;

            case ItemBase.ItemCategory.comida:
                comida.Add(item);
                break;

            case ItemBase.ItemCategory.desechos:
                desechos.Add(item);
                break;

            case ItemBase.ItemCategory.herramientas:
                herramientas.Add(item);
                break;

            case ItemBase.ItemCategory.orbes:
                orbes.Add(item);
                break;

            case ItemBase.ItemCategory.trajes:
                trajes.Add(item);
                break;
        }
    }

    public void RemoveItem(ItemInventario item)
    {
        switch (item.Category)
        {
            case ItemBase.ItemCategory.ajolotes:
                ajolotes.Remove(item);
                break;

            case ItemBase.ItemCategory.comida:
                comida.Remove(item);
                break;

            case ItemBase.ItemCategory.desechos:
                desechos.Remove(item);
                break;

            case ItemBase.ItemCategory.herramientas:
                herramientas.Remove(item);
                break;

            case ItemBase.ItemCategory.orbes:
                orbes.Remove(item);
                break;

            case ItemBase.ItemCategory.trajes:
                trajes.Remove(item);
                break;
        }
    }
}
