using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ItemInventoryTypeDef;
[System.Serializable]
public class SistemaInventario 
{

    [SerializeField]
    public List<ItemInventario> recolectables = new List<ItemInventario>();

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
        global_clear();
    
    }

    public void global_clear()
    {
        recolectables.Clear();
        pasivas.Clear();
        herramientas.Clear();
        ajolotes.Clear();

    }


    //Agrega un elemento del inventario y si ya existe aumenta el stack del elemento de la lista 
    public void AddItem(ItemInventario item)
    {
        switch (item.Category)
        {

            case ItemCategory.recolectables:



                //desde aqui se maneja la logica si es que exite o no el objeto
                if (recolectables.Contains(item))
                {
                    recolectables.Find(x => x.Name == item.Name).stack_value += item.stack_value;
                    GameMaster.instanciaCompartida.GUI_controlador.actualizar_recolectables(item);

                }
                else
                {
                    recolectables.Add(item);
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_recolectables(item);
                }






                break;

            case ItemCategory.herramientas:
                herramientas.Add(item);

                GameMaster.instanciaCompartida.GUI_controlador.actualizar_herramientas(item);
                break;

            case ItemCategory.pasivas:
                pasivas.Add(item);


                GameMaster.instanciaCompartida.GUI_controlador.actualizar_pasivas(item);
                break;

            case ItemCategory.ajolotes:
                ajolotes.Add(item);
                GameMaster.instanciaCompartida.GUI_controlador.actualizar_ajolotes(item);
                break;


        }
       
    }

         
        //Esta funcion movera del inventario del juego hacia la incubadora o otros lados
        public void MoveItemTo()
        {


        }


        //TO DO: AQUI SE NECESITA HACER TAMBIEN UNA ACTUALIZACION A LA UI para liberar el slot
        public void RemoveItem(ItemInventario item)
    {
        switch (item.Category)
        {
            

            case ItemCategory.recolectables:
                recolectables.Remove(item);
                break;

            case ItemCategory.herramientas:
                herramientas.Remove(item);
                break;

            case ItemCategory.pasivas:
                pasivas.Remove(item);
                break;

            case ItemCategory.ajolotes:
                ajolotes.Remove(item);
                break;



        }
    }

}
