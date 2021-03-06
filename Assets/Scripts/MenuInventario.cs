﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using System;
using SlotTipos;

[System.Serializable]
public class slot 
{
   public slot(string slotname, Text slotstack, Image slotui, bool isused)
    {
        Slot_name = slotname;
        Slot_stack = slotstack;
        Slot_ui_img = slotui;
        Is_used = isused;
    }

    public slot(ItemInventoryTypeDef.ItemCategory slot_type_item,string real_obj_name)
    {
        item_inside_type = slot_type_item;
        RealItemName = real_obj_name;
    }

    public string Slot_name;
   
    public Text Slot_stack;
 
    public Image Slot_ui_img;

    public ItemInventoryTypeDef.ItemCategory item_inside_type;// este se llenara cuando un objeto sea introducido en el slot vacio
    public string RealItemName="NotAssignedYet";
    public bool Is_used;

}
//EN DESUSO
public class slotComparer : Comparer<slot>
{
    public override int Compare(slot x, slot y)
    {
        if (x.item_inside_type == y.item_inside_type && x.RealItemName == y.RealItemName)
            return 1;
        else
            return 0;
    }

}

public class MenuInventario : MonoBehaviour
{
    public RectTransform mochila, ajolotepedia, logrosMisiones, mapa, ajolotepediaDesconocido, ajolotepediaPlanta, ajolotepediaAgua, ajolotepediaFuego,
         ajolotepediaHielo, ajolotepediaNube, ajolotepediaOro, ajolotepediaLegendario, ajolotepediaASA, ajolotepediaASF, ajolotepediaASN, bPlanta, bAgua, bFuego,
         bHielo, bNube, bOro, bLegendario, bASA, bASF, bASN;
    public static bool menuCerrado = false;
    public GameObject inventario_ui;
    public bool r1 = false, r2 = false, r3 = false, r4 = false, r5 = false, r6 = false, r7 = false, r8 = false, r9 = false, r10 = false;
    private bool vap = false, vaa = false, vaf = false, vah = false, van = false, vao = false, val = false, vasa = false, vasf = false, vasn = false, vad = false;
    public int dinero, ajoloteActivo;
    public Text uiDinero;
    public Text DescripcionM;

    //Estas son las preterminadas configuradas en el editor (cambiar esto para beneficio muto)

    [SerializeField]
    public List<slot> ajolotes = new List<slot>();
    [SerializeField]
    public List<slot> coleccionables = new List<slot>();
    [SerializeField]
    public List<slot> herramientas = new List<slot>();
    [SerializeField]
    public List<slot> pasivas = new List<slot>();

    public slotComparer SeekForCategory = new slotComparer();
    
    public string EnumerationName = "Slot";
    public string SlotImageName = "SpriteImage";
    public bool llenoR=false,llenoA=false;
    public int contadorA=0, contadorR=0;
    public int contador10AjoA = 0,contador10AjoP=0,contador10AjoF=0,contador10AjoH=0,contador10AjoN=0,contador10AjoO=0;
    //Clases para cada tipo de botones del inventario -añadidos
    uint indice_a = 0, indice_c = 0, indice_h = 0, indice_p = 0;

    public HerramientaSeleccionada conexH;

    public SlotID ajos1, ajos2, ajos3, ajos4, herrs1, herrs2, herr3, herr4, pass1, pass2, pass3, cols1, cols2, cols3, cols4, cols5, cols6, cols7, cols8;
    private void Start()
    {
        GameMaster.instanciaCompartida.SetUI(this);       

        ajolotes.Add(new slot(EnumerationName + (++indice_a).ToString(),
                            null,
                            ajos1.transform.Find(SlotImageName).GetComponent<Image>()
                            , false));
        ajolotes.Add(new slot(EnumerationName + (++indice_a).ToString(),
                           null,
                           ajos2.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        ajolotes.Add(new slot(EnumerationName + (++indice_a).ToString(),
                           null,
                           ajos3.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        ajolotes.Add(new slot(EnumerationName + (++indice_a).ToString(),
                           null,
                           ajos4.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));


        
                        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                           cols1.gameObject.GetComponentInChildren<Text>(true),
                           cols1.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols2.gameObject.GetComponentInChildren<Text>(true),
                          cols2.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols3.gameObject.GetComponentInChildren<Text>(true),
                          cols3.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols4.gameObject.GetComponentInChildren<Text>(true),
                          cols4.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols5.gameObject.GetComponentInChildren<Text>(true),
                          cols5.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols6.gameObject.GetComponentInChildren<Text>(true),
                          cols6.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols7.gameObject.GetComponentInChildren<Text>(true),
                          cols7.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                          cols8.gameObject.GetComponentInChildren<Text>(true),
                          cols8.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));

        herramientas.Add(new slot(EnumerationName + (++indice_h).ToString(),
                          null,
                          herrs1.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        herramientas.Add(new slot(EnumerationName + (++indice_h).ToString(),
                          null,
                          herrs2.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        herramientas.Add(new slot(EnumerationName + (++indice_h).ToString(),
                          null,
                          herr3.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        herramientas.Add(new slot(EnumerationName + (++indice_h).ToString(),
                          null,
                          herr4.transform.Find(SlotImageName).GetComponent<Image>()
                          , false));
        pasivas.Add(new slot(EnumerationName + (++indice_p).ToString(),
                           null,
                           pass1.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        pasivas.Add(new slot(EnumerationName + (++indice_p).ToString(),
                           null,
                           pass2.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        pasivas.Add(new slot(EnumerationName + (++indice_p).ToString(),
                           null,
                           pass3.transform.Find(SlotImageName).GetComponent<Image>()
                           , false));
        

                    
        
    }

    void Update()
    {
        uiDinero.text = "Oro : " + GameMaster.instanciaCompartida.dinero;
        if (Input.GetButtonDown("i"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            GameMaster.instanciaCompartida.mostrarMochila = true;
            GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
            GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
            GameMaster.instanciaCompartida.mostrarMapa = false;
            mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
            mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
            ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
            logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
            if (menuCerrado)
            {
                var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
                var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
                var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed = 15f;
                var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = 30f;
                mouseLook.XSensitivity = 2F;
                mouseLook.YSensitivity = 2F;
                ToggleInventario();
                inventario_ui.SetActive(false);
                conexH.menuAbierto = false;
                menuCerrado = false;
            }
            else
            {
                var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
                var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
                var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed = 0f;
                var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = 0f;
                mouseLook.XSensitivity = 0.0F;
                mouseLook.YSensitivity = 0.0F;
                inventario_ui.SetActive(true);
                conexH.menuAbierto = true;
                menuCerrado = true;
            }
        }


        bPlanta.gameObject.SetActive(r1);
        bAgua.gameObject.SetActive(r2);
        bFuego.gameObject.SetActive(r3);
        bHielo.gameObject.SetActive(r4);
        bNube.gameObject.SetActive(r5);
        bOro.gameObject.SetActive(r6);
        bLegendario.gameObject.SetActive(r7);
        bASA.gameObject.SetActive(r8);
        bASF.gameObject.SetActive(r9);
        bASN.gameObject.SetActive(r10);

        foreach (var iterador in coleccionables)
        {
            if(!iterador.Is_used)
            {
                llenoR = false;
            }
            else
            {
                llenoR = true;
            }
        }

        foreach (var iterador in ajolotes)
        {
            if (!iterador.Is_used)
            {
                llenoA = false;
            }
            else
            {
                llenoA = true;
            }
        }
    }

    public void Inventario()
    {
        ToggleInventario();
    }

    public void Mochila()
    {
        GameMaster.instanciaCompartida.mostrarMochila = true;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void Ajolotepedia()
    {
        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = true;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void LogrosMisiones()
    {
        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = true;
        GameMaster.instanciaCompartida.mostrarMapa = false;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void Mapa()
    {
        GameMaster.instanciaCompartida.mostrarMochila = false;
        GameMaster.instanciaCompartida.mostrarAjolotepedia = false;
        GameMaster.instanciaCompartida.mostrarLogrosMisiones = false;
        GameMaster.instanciaCompartida.mostrarMapa = true;
        mapa.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMapa);
        mochila.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarMochila);
        ajolotepedia.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarAjolotepedia);
        logrosMisiones.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarLogrosMisiones);
    }

    public void ToggleInventario()
    {
        GameMaster.instanciaCompartida.mostrarInventario = !GameMaster.instanciaCompartida.mostrarInventario;
        inventario_ui.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarInventario);
    }

    public void insertar_recolectables(ItemInventario last_entry)
    {
        


            //si no se encontro un objeto lo metemos como nuevo
            foreach (var iterador in coleccionables)
            {
                if (!iterador.Is_used) //buscamos el primer slot libre
                {
                //Asignamos el sprite de bg y ajustamos el stack
                if (llenoR == false)
                {
                    iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                    
                    iterador.Is_used = true;
                    iterador.item_inside_type = last_entry.Category;
                    iterador.RealItemName = last_entry.Nombre;
                    Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                    break;
                }
                }

                
            }
        
    }

    public void actualizar_recolectables(ItemInventario last_entry)
    {
        //Buscamos un slot relacionado con el mismo tipo de last entry
        foreach (var iterador_recolectables in coleccionables)
        {
            if (iterador_recolectables.RealItemName == last_entry.Nombre && iterador_recolectables.item_inside_type == last_entry.Category)
            {
                iterador_recolectables.Slot_stack.text = last_entry.Stack_value.ToString();
                Debug.Log($"ui recoletables updated name: {last_entry.Nombre}   category {last_entry.Category.ToString()} stack value :" + last_entry.Stack_value);
                break;
            }
        }
    }

    public void quitar_recolectables(ItemInventario last_entry)
    {
        foreach (var iterador in coleccionables)
        {
            if (iterador.Is_used) //buscamos el primer slot libre
            {
                foreach (var iterador_coleccionables in coleccionables)
                {
                    //Asignamos el sprite de bg y ajustamos el stack
                    if (iterador_coleccionables.RealItemName == last_entry.Nombre && iterador_coleccionables.item_inside_type == last_entry.Category)
                    {
                        iterador_coleccionables.Slot_ui_img.sprite = null;
                        iterador_coleccionables.Slot_stack.text = null;
                        iterador_coleccionables.Is_used = false;
                        iterador_coleccionables.item_inside_type = last_entry.Category;
                        iterador_coleccionables.RealItemName = null;
                        Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                        break;
                    }
                }
            }
        }
    }

    public void insertar_herramientas(ItemInventario last_entry)
    {
        //si no se encontro un objeto lo metemos como nuevo
        foreach (var iterador in herramientas)
        {
            if (iterador.Slot_name == "Slot1" && last_entry.name == "Lanza")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;

                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot2" && last_entry.name == "Rastrillo")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;

                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot3" && last_entry.name == "AjoloteEnlatado")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot3" && last_entry.name == "AjoloteSAgua")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                r8 = true;
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot4" && last_entry.name == "AjoloteApagado")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot4" && last_entry.name == "AjoloteSFuego")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                r9 = true;
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot1" && last_entry.name == "Arco")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;

                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
        }
    }

    public void quitar_herramientas(ItemInventario last_entry)
    {
        foreach (var iterador in herramientas)
        {
            if (iterador.Is_used) //buscamos el primer slot libre
            {
                //Asignamos el sprite de bg y ajustamos el stack

                iterador.Slot_ui_img.sprite = null;
                iterador.Slot_stack.text = last_entry.Stack_value.ToString();
                iterador.Is_used = false;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = null;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                break;
            }
        }
    }

    public void insertar_pasivas(ItemInventario last_entry)
    {
        foreach (var iterador in pasivas)
        {
            if (iterador.Slot_name == "Slot1" && last_entry.name == "AmuletoFuego")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;

                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot3" && last_entry.name == "AmuletoHielo")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;

                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
            else if (iterador.Slot_name == "Slot2" && last_entry.name == "AjoloteSNube")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                r10 = true;
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
            }
        }
    }

    public void quitar_pasivas(ItemInventario last_entry)
    {
        foreach (var iterador in pasivas)
        {
            if (iterador.Is_used) //buscamos el primer slot libre
            {
                //Asignamos el sprite de bg y ajustamos el stack

                iterador.Slot_ui_img.sprite = null;
                iterador.Slot_stack.text = last_entry.Stack_value.ToString();
                iterador.Is_used = false;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = null;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                break;
            }
        }
    }

    public void insertar_ajolotes(ItemInventario last_entry)
    {
        //si no se encontro un objeto lo metemos como nuevo
        


            foreach (var iterador in ajolotes)
            {
                if (!iterador.Is_used) //buscamos el primer slot libre
                {
                 
                 if (llenoA == false)
                 {
                    
                    iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                    
                    iterador.Is_used = true;
                    

                    iterador.item_inside_type = last_entry.Category;
                    iterador.RealItemName = last_entry.Nombre;

                    if(iterador.RealItemName == "AjoloteDePlanta")
                    {
                        contador10AjoP += 1;
                    }
                    else if(iterador.RealItemName=="AjoloteDeAgua")
                    {
                        contador10AjoA += 1;
                    }
                    else if (iterador.RealItemName == "AjoloteDeFuego")
                    {
                        contador10AjoF += 1;
                    }
                    else if (iterador.RealItemName == "AjoloteDeHielo")
                    {
                        contador10AjoH += 1;
                    }
                    else if (iterador.RealItemName == "AjoloteDeNube")
                    {
                        contador10AjoN += 1;
                    }
                    else if (iterador.RealItemName == "AjoloteDeOro")
                    {
                        contador10AjoO += 1;
                    }

                    Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                    break;
                 }
                 
                }
                

               
            }
        
    }

    public void quitar_ajolotes(ItemInventario last_entry)
    {
        foreach (var iterador in ajolotes)
        {
            if (iterador.Is_used) //buscamos el primer slot libre
            {
                foreach (var iterador_ajolotes in ajolotes)
                {
                    if (iterador_ajolotes.RealItemName == last_entry.Nombre && iterador_ajolotes.item_inside_type == last_entry.Category)
                    {
                        iterador_ajolotes.RealItemName = null;
                        iterador_ajolotes.Is_used = false;
                        iterador_ajolotes.Slot_ui_img.sprite = null;
                        iterador_ajolotes.Slot_stack.text = last_entry.Stack_value.ToString();
                        iterador_ajolotes.item_inside_type = last_entry.Category;
                       
                        
                        Debug.Log($"ui recoletables updated name: {last_entry.Nombre}   category {last_entry.Category.ToString()} stack value :" + last_entry.Stack_value);
                        break;
                    }
                }
            }
        }
    }
        public void RegistrarAjolote()
        {

        }

        public void ToggleDesconocido()
        {


            vad = !vad;
            ajolotepediaDesconocido.gameObject.SetActive(vad);

        }

        public void ToggleAP()
        {
            if (r1 == true)
            {
                vap = !vap;
                ajolotepediaPlanta.gameObject.SetActive(vap);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAA()
        {
            if (r2 == true)
            {
                vaa = !vaa;
                ajolotepediaAgua.gameObject.SetActive(vaa);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAF()
        {
            if (r3 == true)
            {
                vaf = !vaf;
                ajolotepediaFuego.gameObject.SetActive(vaf);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAH()
        {
            if (r4 == true)
            {
                vah = !vah;
                ajolotepediaHielo.gameObject.SetActive(vah);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAN()
        {
            if (r5 == true)
            {
                van = !van;
                ajolotepediaNube.gameObject.SetActive(van);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAO()
        {
            if (r6 == true)
            {
                vao = !vao;
                ajolotepediaOro.gameObject.SetActive(vao);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleAL()
        {
            if (r7 == true)
            {
                val = !val;
                ajolotepediaLegendario.gameObject.SetActive(val);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleASA()
        {
            if (r8 == true)
            {
                vasa = !vasa;
                ajolotepediaASA.gameObject.SetActive(vasa);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleASF()
        {
            if (r9 == true)
            {
                vasf = !vasf;
                ajolotepediaASF.gameObject.SetActive(vasf);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void ToggleASN()
        {
            if (r10 == true)
            {
                vasn = !vasn;
                ajolotepediaASN.gameObject.SetActive(vasn);
            }
            else
            {
                ToggleDesconocido();
            }
        }

        public void MostrarMisionDescripcion1()
        {
            DescripcionM.text = "Hola joven\n \n Para iniciar tu aventura necesitas aprender sobre este mundo, yo te dire lo basico \n\n Ve a la tienda y compra una lanza" +
            " para que puedas pescar en un lago, yo te recomiendo el bosque, podras conseguir peces, a los ajolotes les encantan los peces \n\n Compra un rastrillo de tierra" +
            " cuando veas tierra levantada significa que hay gusanos, y los gusanos son muy nutritivos para los ajolotes \n\n Hablando de ajolotes son una muy buena fuente de ingreso" +
            " comprame un criadero te lo dare a buen precio pero los demas te costaran cada vez mas, si logras capturar un ajolote puedes ponerlo en el criadero" +
            " los desechos que generan son muy valiosos ¿sabes? \n\n Entonces consigue un ajolote y alimentalo en el criadero para iniciar tu aventura";
        }

        public void MostrarMisionDescripcion2()
        {
            DescripcionM.text = "Hay 5 tipos diferentes de ajolotes en esta region, equipamos tu casa con un analizador para que los registres \n\n" +
            "te daremos dinero y se agregara su informacion a tu ajolotipedia, registra: \n\n Ajolote de planta \n Ajolote de agua \n Ajolote de fuego" +
            " \n Ajolote de hielo \n Ajolote de nube";
        }

    public void MostrarMisionDescripcion3()
    {
        DescripcionM.text = "Hmmmmm veo que eres bueno con la lanza, trata de pescar 10 peces de manera consecutiva y pondre a la venta mi arco pescador en la tienda" +
            " a ver si como crias pescas";
    }

    public void MostrarMisionDescripcion4()
    {
        DescripcionM.text = "Joven!!!!, un dia que andaba en las cuevas acuaticas perdi mi pantalon preferido No.1 de la VIDA, te dare una reliquia si lo encuentras y me lo traes" +
            " te lo pido por favor joven, traeme mis pantalones preferidos :c";
    }

    public void MostrarMisionDescripcion5()
    {
        DescripcionM.text = "JOVEN!!! fui a buscar un poco de tierra para mi plantita en el volcan, pero como hacia mucho calor me quite mi saco preferido, y cuando sali " +
            "lo deje en algun lado, ya no pude entrar desde que cayo esa roca, te dare otra reliquia si me recuperas mi saco ¿puedes traerme mi saco preferido por favor joven? :'c";
    }

    public void MostrarMisionDescripcion6()
    {
        DescripcionM.text = "JOOOOOOOOOOOOOOOOOOOOOOOOOVEEEEEEEEEEEEN!!!!!! fui a pasear hace rato y aparecio un vendaval muy fuerte que me deja casi pelon, " +
            "pero no me dejo pelon, si no que me dejo sin mi sombrero favorito, trate de ver donde cayo, pero parece que no cayo y no lo encuentro por todo " +
            "el suelo, si lo encuentras te dare mi ultima reliquia, POR FAVOR JOVEN TRAEME MI SOMBRERO FAVORITO DE REGRESO :'''(((((";
    }

    public void MostrarMisionDescripcion7()
    {
        DescripcionM.text = "En estos dias si que le entra hambre a uno, ¿no crees? que tal si me traes un huevo de ajolote de planta y otro de agua" +
            "¿Que que voy a hacer con ellos?, no te preocupes quiero criarlos y desayunar con ellos, dicen que desayunar con alguien mas hace mas sabrosa la comida," +
            "si me haces este favor bajare el precio del amuleto contra el fuego, ¿Que te parece?";
    }

    public void MostrarMisionDescripcion8()
    {
        DescripcionM.text = "Ya estaba prendiendo mi horno para prepararme un pan que me enseño a hacer mi madre, pero me di cuanta que nomas no prendia reevise y el combustible " +
            "que uso se acabo, puedes traerme mas combustible, creo que los desechos de los ajolotes de fuego me serviran a la perfeccion " +
            "si me ayudas con esto te bajare el precio del amuleto contra el hielo, ¿Como te quedo el oclayo?";
    }

    public void MostrarMisionDescripcion9()
    {
        DescripcionM.text = "Joven quiero enseñarle a la gente del pueblo sobre su fauna y como veo que eres alguien ya familiarizado con ella, ¿Me puedes traer " +
            "un ajolote de planta, agua y fuego?, te pagare con 1000 de oro, muvhas gracias joven";
    }

    public void MostrarMisionDescripcion10()
    {
        DescripcionM.text = "Joven, la verdad al inicio te estabamos probando, la verdad es que hay otra clase de ajolote, es un ajolote que se cuenta solo en leyendas " +
            "segun eso, se encuentra al fondo de las cuevas, es un recurso muy importante para la ciencia, si lo registras no te pedire nada mas joven, gracias";
    }
}