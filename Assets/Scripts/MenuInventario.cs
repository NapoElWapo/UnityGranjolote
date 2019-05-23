using System.Collections;
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
    private bool vap=false, vaa = false, vaf = false, vah = false, van = false, vao = false, val = false, vasa = false, vasf = false, vasn = false,vad=false;
    public int dinero,ajoloteActivo;
    public Text uiDinero;

    //Estas son las preterminadas configuradas en el editor (cambiar esto para beneficio muto)

    [SerializeField]
    public List<slot> ajolotes= new List<slot>();
    [SerializeField]
    public List<slot> coleccionables = new List<slot>();
    [SerializeField]
    public List<slot> herramientas = new List<slot>();
    [SerializeField]
    public List<slot> pasivas = new List<slot>();

    public slotComparer SeekForCategory = new slotComparer();

    public string EnumerationName = "Slot";
    public string SlotImageName = "SpriteImage";

    //Clases para cada tipo de botones del inventario -añadidos
    uint indice_a = 0, indice_c = 0, indice_h = 0, indice_p = 0;

    private void Start()
    {
        GameMaster.instanciaCompartida.SetUI(this);

        //Buscamos los slots de la ui y los llenamos con sus tipos correspondientes
        //Lo que hace este bucle es buscar todos los objetos con el script slot id para referenciarse ellos despues
        foreach (var iterador_ajolotes in Resources.FindObjectsOfTypeAll (typeof(SlotID)) as SlotID[])
        {
            Debug.Log("procesando :" + iterador_ajolotes.name);
            //Les asignamos el tag correspondiente a Slot+N
            // iterador_ajolotes.gameObject.GetComponentInChildren<>
            switch (iterador_ajolotes.ActualSlotType)
            {

                case SlotObjType.Ajolotes:

                    ajolotes.Add(new slot(EnumerationName + (++indice_a).ToString(),
                        null,
                        iterador_ajolotes.transform.Find(SlotImageName).GetComponent<Image>()
                        , false));
                    break;

                case SlotObjType.Coleccionables:
                    coleccionables.Add(new slot(EnumerationName + (++indice_c).ToString(),
                       iterador_ajolotes.gameObject.GetComponentInChildren<Text>(true),
                       iterador_ajolotes.transform.Find(SlotImageName).GetComponent<Image>()
                       , false));
                    break;

                case SlotObjType.Herramientas:
                    herramientas.Add(new slot(EnumerationName + (++indice_h).ToString(),
                       null,
                       iterador_ajolotes.transform.Find(SlotImageName).GetComponent<Image>()
                       , false));
                    break;

                case SlotObjType.Pasivas:
                    pasivas.Add(new slot(EnumerationName + (++indice_p).ToString(),
                       null,
                       iterador_ajolotes.transform.Find(SlotImageName).GetComponent<Image>()
                       , false));
                    break;
            }
        }
        
        Debug.Log("inventory initialized");
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
                mouseLook.XSensitivity = 2F;
                mouseLook.YSensitivity = 2F;
                ToggleInventario();
                inventario_ui.SetActive(false);
                Time.timeScale = 1f;
                menuCerrado = false;
            }
            else
            {
                var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
                var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
                mouseLook.XSensitivity = 0.0F;
                mouseLook.YSensitivity = 0.0F;
                inventario_ui.SetActive(true);
                Time.timeScale = 0f;
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

                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                iterador.Slot_stack.text = last_entry.Stack_value.ToString();
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                break;       
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
            else if (iterador.Slot_name == "Slot3" && last_entry.name == "AjoloteSAgua")
            {
                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
                r8 = true;
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
    
    public void insertar_ajolotes(ItemInventario last_entry)
    {
        //si no se encontro un objeto lo metemos como nuevo
        foreach (var iterador in ajolotes)
        {
            if (!iterador.Is_used ) //buscamos el primer slot libre
            {
                //Asignamos el sprite de bg y ajustamos el stack

                iterador.Slot_ui_img.sprite = last_entry.Inventory_Decal;
               
                iterador.Is_used = true;
                iterador.item_inside_type = last_entry.Category;
                iterador.RealItemName = last_entry.Nombre;
                Debug.Log($"ui inserted  name: {last_entry.Nombre}   category: {last_entry.Category.ToString()}");
                break;
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
        if(r1==true)
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
}
