using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SistemaInventario 
{
    [SerializeField]
    private List<ItemInventario> recolectables = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> pasivas = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> herramientas = new List<ItemInventario>();

    [SerializeField]
    private List<ItemInventario> ajolotes = new List<ItemInventario>();


    private ItemInventario selectHerramienta;


    public ItemInventario SelectHerramienta
    {
        get { return selectHerramienta; }
        set { selectHerramienta = value; }

    }


    public SistemaInventario()
    {
        recolectables.Clear();
        pasivas.Clear();
        herramientas.Clear();
        ajolotes.Clear();

    }

    public void AddItem(ItemInventario item)
    {
        switch(item.Category)
        {
            


            case ItemBase.ItemCategory.recolectables:
                recolectables.Add(item);
                break;

            case ItemBase.ItemCategory.herramientas:
                herramientas.Add(item);
                break;

            case ItemBase.ItemCategory.pasivas:
                pasivas.Add(item);
                break;

            case ItemBase.ItemCategory.ajolotes:
                ajolotes.Add(item);
                break;


        }
    }

    public void RemoveItem(ItemInventario item)
    {
        switch (item.Category)
        {
            

            case ItemBase.ItemCategory.recolectables:
                recolectables.Remove(item);
                break;

            case ItemBase.ItemCategory.herramientas:
                herramientas.Remove(item);
                break;

            case ItemBase.ItemCategory.pasivas:
                pasivas.Remove(item);
                break;

            case ItemBase.ItemCategory.ajolotes:
                ajolotes.Remove(item);
                break;



        }
    }
}
