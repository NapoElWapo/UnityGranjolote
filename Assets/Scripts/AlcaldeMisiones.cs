using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AlcaldeMisiones : MonoBehaviour
{
    //Variables para poder seleccionar item a entregar
    slot itemslot1, itemslot2, itemslot3, itemslot4, itemslot5, itemslot6, itemslot7, itemslot8,ajoSlot1,ajoSlot2,ajoSlot3,ajoSlot4;
    MenuInventario conex;
    public Image sslot1, sslot2, sslot3, sslot4, sslot5, sslot6, sslot7, sslot8,saslot1,saslot2,saslot3,saslot4;
    public Text stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8;
    public RectTransform bslot1, bslot2, bslot3, bslot4, bslot5, bslot6, bslot7, bslot8,baslot1,baslot2,baslot3,baslot4;
    private int slotSeleccionado = 0;

    //Toggle
    public RectTransform AlcaldeMisionesUI;
    private bool mostrar;

    //Variables para mostrar las misiones disponibles
    public RectTransform MD1, MD2, MD3, MD4, MD5, MD6, MD7, MD8, MD9;
    public bool activa1=false, activa2=false, activa3=false, activa4=false, activa5=false, activa6=false, activa7=false, activa8=false, activa9=false;
    Alcalde conexAl;
    LogrosYMisiones conexLM;

    //Variables para mostrar de aceptar mision y entrega de objetos
    public RectTransform panelA1, panelA2, panelA3, panelA4, panelA5, panelA6, panelA7, panelA8, panelA9, panelE4, panelE5, panelE6, panelE7, panelE8, panelE9;
    public bool aceptada1=false, aceptada2=false, aceptada3=false, aceptada4=false, aceptada5=false, aceptada6=false, aceptada7=false, aceptada8=false, aceptada9=false;
    private int valorEntrega = 0;

    public GameObject current_selected_obj, sombrero, saco, pantalones, huevoP, huevoA, cacasF, ajoA, ajoP, ajoF;

    //MarcarProgreso
    public RectTransform backHP, backHA, backAA, backAP, backAF,backCacasF,backSombrero,backSaco,backPantalones;

    //Objetos a spawnear
    public GameObject pantalonCuevas, sacoVolcan, sombreroNubes;

    Notificaciones conexN;
    

    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
        conexAl = GameObject.Find("Alcalde").GetComponent<Alcalde>();
        conexN = GameObject.Find("NotificacionesDeslizantes").GetComponent<Notificaciones>();

    }

    
    void Update()
    {
        itemslot1 = conex.coleccionables.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = itemslot1.Slot_ui_img.sprite;
        stack1.text = itemslot1.Slot_stack.text;

        itemslot2 = conex.coleccionables.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = itemslot2.Slot_ui_img.sprite;
        stack2.text = itemslot2.Slot_stack.text;

        itemslot3 = conex.coleccionables.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = itemslot3.Slot_ui_img.sprite;
        stack3.text = itemslot3.Slot_stack.text;

        itemslot4 = conex.coleccionables.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = itemslot4.Slot_ui_img.sprite;
        stack4.text = itemslot4.Slot_stack.text;

        itemslot5 = conex.coleccionables.Find(x => x.Slot_name == "Slot5");
        sslot5.sprite = itemslot5.Slot_ui_img.sprite;
        stack5.text = itemslot5.Slot_stack.text;

        itemslot6 = conex.coleccionables.Find(x => x.Slot_name == "Slot6");
        sslot6.sprite = itemslot6.Slot_ui_img.sprite;
        stack6.text = itemslot6.Slot_stack.text;

        itemslot7 = conex.coleccionables.Find(x => x.Slot_name == "Slot7");
        sslot7.sprite = itemslot7.Slot_ui_img.sprite;
        stack7.text = itemslot7.Slot_stack.text;

        itemslot8 = conex.coleccionables.Find(x => x.Slot_name == "Slot8");
        sslot8.sprite = itemslot8.Slot_ui_img.sprite;
        stack8.text = itemslot8.Slot_stack.text;

        ajoSlot1 = conex.ajolotes.Find(x => x.Slot_name == "Slot1");
        saslot1.sprite = ajoSlot1.Slot_ui_img.sprite;
        

        ajoSlot2 = conex.ajolotes.Find(x => x.Slot_name == "Slot2");
        saslot2.sprite = ajoSlot2.Slot_ui_img.sprite;
        

        ajoSlot3 = conex.ajolotes.Find(x => x.Slot_name == "Slot3");
        saslot3.sprite = ajoSlot3.Slot_ui_img.sprite;
        

        ajoSlot4 = conex.ajolotes.Find(x => x.Slot_name == "Slot4");
        saslot4.sprite = ajoSlot4.Slot_ui_img.sprite;
        

        //Cuanta activas para que el alcalde te muestre la interfaz o no
        if (activa1||activa2||activa3||activa4||activa5||activa6||activa7||activa8||activa9)
        {
            Debug.Log("misiones activas");
            conexAl.mision = true;
        }
        else
        {
            conexAl.mision = false;
        }


        //Activa a desactiva
        MD1.gameObject.SetActive(activa1);
        MD2.gameObject.SetActive(activa2);
        MD3.gameObject.SetActive(activa3);
        MD4.gameObject.SetActive(activa4);
        MD5.gameObject.SetActive(activa5);
        MD6.gameObject.SetActive(activa6);
        MD7.gameObject.SetActive(activa7);
        MD8.gameObject.SetActive(activa8);
        MD9.gameObject.SetActive(activa9);
    }

    public void ItemAEntregar()
    {
        
    }

    public void Seleccionar1()
    {
        slotSeleccionado = 1;
        bslot1.gameObject.SetActive(true);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar2()
    {
        slotSeleccionado = 2;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(true);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar3()
    {
        slotSeleccionado = 3;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(true);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar4()
    {
        slotSeleccionado = 4;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(true);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar5()
    {
        slotSeleccionado = 5;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(true);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar6()
    {
        slotSeleccionado = 6;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(true);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar7()
    {
        slotSeleccionado = 7;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(true);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar8()
    {
        slotSeleccionado = 8;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(true);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar9()
    {
        slotSeleccionado = 9;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(true);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar10()
    {
        slotSeleccionado = 10;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(true);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar11()
    {
        slotSeleccionado = 11;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(true);
        baslot4.gameObject.SetActive(false);
    }

    public void Seleccionar12()
    {
        slotSeleccionado = 12;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
        bslot5.gameObject.SetActive(false);
        bslot6.gameObject.SetActive(false);
        bslot7.gameObject.SetActive(false);
        bslot8.gameObject.SetActive(false);
        baslot1.gameObject.SetActive(false);
        baslot2.gameObject.SetActive(false);
        baslot3.gameObject.SetActive(false);
        baslot4.gameObject.SetActive(true);
    }

    public void ToggleAMisiones()
    {


        mostrar = !mostrar;
        AlcaldeMisionesUI.gameObject.SetActive(mostrar);

        if (mostrar)
        {
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed=0f;
            var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed=0f;
           
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            
           
        }
        else if (!mostrar)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            var velocidadC = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_WalkSpeed = 15f;
            var velocidadR = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = 30f;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            
        }


    }

    public void MostrarPanel1()
    {
        if (aceptada1==false)
        {


            panelA1.gameObject.SetActive(true);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel2()
    {
        if (aceptada2 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(true);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel3()
    {
        if (aceptada3 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(true);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 3;
            panelE4.gameObject.SetActive(true);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel4()
    {
        if (aceptada4 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(true);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 4;
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(true);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel5()
    {
        if (aceptada5 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(true);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 5;
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(true);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel6()
    {
        if (aceptada6 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(true);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 6;
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(true);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel7()
    {
        if (aceptada7 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(true);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 7;
            panelE4.gameObject.SetActive(true);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(true);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void MostrarPanel8()
    {
        if (aceptada8 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(true);
            panelA9.gameObject.SetActive(false);
        }
        else
        {
            valorEntrega = 8;
            panelE4.gameObject.SetActive(true);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(true);
        }
    }

    public void MostrarPanel9()
    {
        if (aceptada9 == false)
        {


            panelA1.gameObject.SetActive(false);
            panelA2.gameObject.SetActive(false);
            panelA3.gameObject.SetActive(false);
            panelA4.gameObject.SetActive(false);
            panelA5.gameObject.SetActive(false);
            panelA6.gameObject.SetActive(false);
            panelA7.gameObject.SetActive(false);
            panelA8.gameObject.SetActive(false);
            panelA9.gameObject.SetActive(true);
        }
        else
        {
            panelE4.gameObject.SetActive(false);
            panelE5.gameObject.SetActive(false);
            panelE6.gameObject.SetActive(false);
            panelE7.gameObject.SetActive(false);
            panelE8.gameObject.SetActive(false);
            panelE9.gameObject.SetActive(false);
        }
    }

    public void Aceptar1()
    {
        aceptada1 = true;
        panelA1.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);

        conexN.popD();
        conexLM.m2.gameObject.SetActive(true);
        
    }

    public void Aceptar2()
    {
        aceptada2 = true;
        panelA2.gameObject.SetActive(false);
        panelA1.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);
        conexLM.m3.gameObject.SetActive(true);
        conexLM.mision3Alcalde = true;
        conexN.popD();
    }

    public void Aceptar3()
    {
        aceptada3 = true;
        panelA3.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(true);

        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);
        conexLM.m4.gameObject.SetActive(true);
        pantalonCuevas.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar4()
    {
        aceptada4 = true;
        panelA4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(true);
        panelE4.gameObject.SetActive(false);

        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);
        conexLM.m5.gameObject.SetActive(true);
        sacoVolcan.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar5()
    {
        aceptada5 = true;
        panelA5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(true);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);

        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);
        conexLM.m6.gameObject.SetActive(true);
        sombreroNubes.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar6()
    {
        aceptada6 = true;
        panelA6.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);

        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(true);

        conexLM.m7.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar7()
    {
        aceptada7 = true;
        panelA7.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);

        panelE9.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(true);

        conexLM.m8.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar8()
    {
        aceptada8 = true;
        panelA8.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(true);
        conexN.popD();
    }

    public void Aceptar9()
    {
        aceptada9 = true;
        panelA9.gameObject.SetActive(false);
        panelA1.gameObject.SetActive(false);
        panelE4.gameObject.SetActive(false);
        panelE5.gameObject.SetActive(false);
        panelE6.gameObject.SetActive(false);
        panelE7.gameObject.SetActive(false);
        panelE8.gameObject.SetActive(false);
        panelE9.gameObject.SetActive(false);

        conexLM.m10.gameObject.SetActive(true);
        conexN.popD();

    }

    public void Entregar()
    {
        switch(valorEntrega)
        {
            case 5:

                switch(slotSeleccionado)
                {
                    case 1:
                        if (itemslot1.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 2:
                        if (itemslot2.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 3:
                        if (itemslot3.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 4:
                        if (itemslot4.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 5:
                        if (itemslot5.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 6:
                        if (itemslot6.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 7:
                        if (itemslot7.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;

                    case 8:
                        if (itemslot8.RealItemName == "Sombrero")
                        {
                            current_selected_obj = sombrero.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSombrero.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sombreroEntregado = true;
                        }
                        break;
                }
               
                
                break;

            case 4:

                switch (slotSeleccionado)
                {
                    case 1:
                        if (itemslot1.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 2:
                        if (itemslot2.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 3:
                        if (itemslot3.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 4:
                        if (itemslot4.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 5:
                        if (itemslot5.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 6:
                        if (itemslot6.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 7:
                        if (itemslot7.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;

                    case 8:
                        if (itemslot8.RealItemName == "Saco")
                        {
                            current_selected_obj = saco.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backSaco.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.sacoEntregado = true;
                        }
                        break;
                }

                break;

            case 3:

                switch (slotSeleccionado)
                {
                    case 1:
                        if (itemslot1.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 2:
                        if (itemslot2.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 3:
                        if (itemslot3.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 4:
                        if (itemslot4.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 5:
                        if (itemslot5.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 6:
                        if (itemslot6.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 7:
                        if (itemslot7.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;

                    case 8:
                        if (itemslot8.RealItemName == "Pantalon")
                        {
                            current_selected_obj = pantalones.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backPantalones.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.pantalonEntregado = true;
                        }
                        break;
                }

                break;

            case 6:

                switch (slotSeleccionado)
                {
                    case 1:
                        if (itemslot1.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot1.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 2:
                        if (itemslot2.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot2.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 3:
                        if (itemslot3.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot3.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 4:
                        if (itemslot4.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot4.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 5:
                        if (itemslot5.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot5.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 6:
                        if (itemslot6.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot6.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 7:
                        if (itemslot7.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot7.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;

                    case 8:
                        if (itemslot8.RealItemName == "HuevoPlanta")
                        {
                            current_selected_obj = huevoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoPEntregado = true;
                        }
                        else if (itemslot8.RealItemName == "HuevoAgua")
                        {
                            current_selected_obj = huevoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backHA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.huevoAEntregado = true;
                        }
                        break;
                }

                break;

            case 7:
                switch (slotSeleccionado)
                {
                    case 1:
                        if (itemslot1.RealItemName == "CacaFuego")
                        {
                            if(itemslot1.Slot_stack.text=="15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }
                            
                        }
                        break;

                    case 2:
                        if (itemslot2.RealItemName == "CacaFuego")
                        {
                            if (itemslot2.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 3:
                        if (itemslot3.RealItemName == "CacaFuego")
                        {
                            if (itemslot3.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 4:
                        if (itemslot4.RealItemName == "CacaFuego")
                        {
                            if (itemslot4.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 5:
                        if (itemslot5.RealItemName == "CacaFuego")
                        {
                            if (itemslot5.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 6:
                        if (itemslot6.RealItemName == "CacaFuego")
                        {
                            if (itemslot6.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 7:
                        if (itemslot7.RealItemName == "CacaFuego")
                        {
                            if (itemslot7.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;

                    case 8:
                        if (itemslot8.RealItemName == "CacaFuego")
                        {
                            if (itemslot8.Slot_stack.text == "15")
                            {
                                current_selected_obj = cacasF.transform.gameObject;
                                for (int i = 0; i < 15; i++)
                                {
                                    GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                                }

                                backCacasF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                                conexLM.cacasFEntregadas = true;
                            }

                        }
                        break;
                }
                break;

            case 8:
                switch (slotSeleccionado)
                {
                    case 9:
                        if (ajoSlot1.RealItemName == "AjoloteDePlanta")
                        {
                            current_selected_obj = ajoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerPEntregado = true;
                        }
                        else if (ajoSlot1.RealItemName == "AjoloteDeAgua")
                        {
                            current_selected_obj = ajoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerAEntregado = true;
                        }
                        else if (ajoSlot1.RealItemName == "AjoloteDeFuego")
                        {
                            current_selected_obj = ajoF.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerFEntregado = true;
                        }
                        break;

                    case 10:
                        if (ajoSlot2.RealItemName == "AjoloteDePlanta")
                        {
                            current_selected_obj = ajoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerPEntregado = true;
                        }
                        else if (ajoSlot2.RealItemName == "AjoloteDeAgua")
                        {
                            current_selected_obj = ajoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerAEntregado = true;
                        }
                        else if (ajoSlot2.RealItemName == "AjoloteDeFuego")
                        {
                            current_selected_obj = ajoF.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerFEntregado = true;
                        }
                        break;

                    case 11:
                        if (ajoSlot3.RealItemName == "AjoloteDePlanta")
                        {
                            current_selected_obj = ajoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerPEntregado = true;
                        }
                        else if (ajoSlot3.RealItemName == "AjoloteDeAgua")
                        {
                            current_selected_obj = ajoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerAEntregado = true;
                        }
                        else if (ajoSlot3.RealItemName == "AjoloteDeFuego")
                        {
                            current_selected_obj = ajoF.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerFEntregado = true;
                        }
                        break;

                    case 12:
                        if (ajoSlot4.RealItemName == "AjoloteDePlanta")
                        {
                            current_selected_obj = ajoP.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAP.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerPEntregado = true;
                        }
                        else if (ajoSlot4.RealItemName == "AjoloteDeAgua")
                        {
                            current_selected_obj = ajoA.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAA.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerAEntregado = true;
                        }
                        else if (ajoSlot4.RealItemName == "AjoloteDeFuego")
                        {
                            current_selected_obj = ajoF.transform.gameObject;
                            GameMaster.instanciaCompartida.inventario.RemoveItem(current_selected_obj?.GetComponent<ItemInventario>());
                            backAF.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                            conexLM.primerFEntregado = true;
                        }
                        break;

                   
                }
                break;
        }
    }
}
