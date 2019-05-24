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
                        var tmp_obj = recolectables.Find(x => x.Nombre.Contains(item.Nombre));
                        Debug.Log("updating slot..");
                    

                    //
                    tmp_obj.Stack_value ++;
                    if (tmp_obj.Stack_value > item.MaxStack) 
                        return true;

                    GameMaster.instanciaCompartida.GUI_controlador.actualizar_recolectables(tmp_obj);
                    Debug.Log("objeto actualizado desde invetory sistem"+ tmp_obj.ToString());
                    return false;
                    }
                    else
                    return true;
                }
                else if (GameMaster.instanciaCompartida.GUI_controlador.llenoR==false)
                {
                    recolectables.Add(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_recolectables(item);
                    return false;
                }
                else
                    return true;
                break;

            case ItemCategory.herramientas:

                if (herramientas.Contains(item))
                {                   
                        return true;
                }
                else
                {
                    herramientas.Add(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_herramientas(item);
                }
                break;

            case ItemCategory.pasivas:
                if (pasivas.Contains(item))
                {

                    return true;
                }
                else
                {
                    pasivas.Add(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_pasivas(item);
                }
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
                else if (GameMaster.instanciaCompartida.GUI_controlador.llenoA == false)
                {
                    ajolotes.Add(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.insertar_ajolotes(item);
                    return false;
                }
                else
                    return true;
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
                //recolectables.Remove(item);
                if (recolectables.Contains(item))
                {
                    if (item.Stackeble)
                    {
                        Debug.Log("updating slot..");
                        var tmp_obj = recolectables.Find(x => x.Nombre.Contains(item.Nombre));

                        //
                        tmp_obj.Stack_value--;
                        if (tmp_obj.Stack_value <= 1)
                            recolectables.Remove(item);
                           
                            

                        GameMaster.instanciaCompartida.GUI_controlador.actualizar_recolectables(tmp_obj);
                        GameMaster.instanciaCompartida.GUI_controlador.quitar_recolectables(tmp_obj);
                        Debug.Log("objeto actualizado desde invetory sistem" + tmp_obj.ToString());
                        
                    }
                    else
                    {
                        var tmp_obj = recolectables.Find(x => x.Nombre.Contains(item.Nombre));
                        recolectables.Remove(item);
                        GameMaster.instanciaCompartida.GUI_controlador.quitar_recolectables(tmp_obj);
                    }
                   
                       
                }
                
                break;

            case ItemCategory.herramientas:
                if (herramientas.Contains(item))
                {
                    var tmp_obj = herramientas.Find(x => x.Nombre.Contains(item.Nombre));
                    tmp_obj.Stack_value--;
                    if (tmp_obj.Stack_value < 1)
                    {
                        herramientas.Remove(item);
                        GameMaster.instanciaCompartida.GUI_controlador.quitar_herramientas(tmp_obj);
                    }
                }
                break;

            case ItemCategory.pasivas:
                if(pasivas.Contains(item))
                {
                    pasivas.Remove(item);//se agrega si no existe
                    GameMaster.instanciaCompartida.GUI_controlador.quitar_pasivas(item);
                }
                
                break;

            case ItemCategory.ajolotes:
                if (ajolotes.Contains(item))
                {
                    if (item.Stackeble)
                    {
                        Debug.Log("updating slot..");
                        var tmp_obj = ajolotes.Find(x => x.Nombre.Contains(item.Nombre));

                        //
                        tmp_obj.Stack_value --;
                        if (tmp_obj.Stack_value < 1)
                            ajolotes.Remove(item);

                        Debug.Log("objeto actualizado desde invetory sistem" + tmp_obj.ToString());
                       
                    }
                    else
                    {
                        ajolotes.Remove(item);//se agrega si no existe
                        GameMaster.instanciaCompartida.GUI_controlador.quitar_ajolotes(item);
                    }

                }
               
                break;
        }
    }
}
