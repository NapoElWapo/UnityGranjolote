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
    public bool AddItem(ItemInventario item)
    {
        switch (item.Category)
        {

            case ItemCategory.recolectables:
                //desde aqui se maneja la logica si es que exite o no el objeto
                if (recolectables.Contains(item))
                {
                    if (item.Stackeble)
                    { 
                    Debug.Log("updating slot..");
                    var tmp_obj = recolectables.Find(x => x.Nombre.Contains(item.Nombre) );

                    //
                    tmp_obj.Stack_value += item.Stack_value;
                    if (tmp_obj.Stack_value > item.MaxStack) 
                        return true;

                    GameMaster.instanciaCompartida.GUI_controlador.actualizar_recolectables(tmp_obj);
                    Debug.Log("objeto actualizado desde invetory sistem"+ tmp_obj.ToString());
                    return false;
                    }
                    else
                    return true;
                }
                else
                {
                    recolectables.Add(item);//se agrega si no existe
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
                //ajolotes.Add(item);
                //GameMaster.instanciaCompartida.GUI_controlador.actualizar_ajolotes(item);
                //break;
                if (ajolotes.Contains(item))
                {
                    if (item.Stackeble)
                    {
                        Debug.Log("updating slot..");
                        var tmp_obj = ajolotes.Find(x => x.Nombre.Contains(item.Nombre));

                        //
                        tmp_obj.Stack_value += item.Stack_value;
                        if (tmp_obj.Stack_value > item.MaxStack)
                            return true;

                       
                        Debug.Log("objeto actualizado desde invetory sistem" + tmp_obj.ToString());
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    ajolotes.Add(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_ajolotes(item);
                }
                break;


        }

        return false;
       
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
