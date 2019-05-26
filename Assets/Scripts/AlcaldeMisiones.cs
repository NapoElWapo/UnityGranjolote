using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AlcaldeMisiones : MonoBehaviour
{
    //Variables para poder seleccionar item a entregar
    slot itemslot1, itemslot2, itemslot3, itemslot4, itemslot5, itemslot6, itemslot7, itemslot8;
    MenuInventario conex;
    public Image sslot1, sslot2, sslot3, sslot4, sslot5, sslot6, sslot7, sslot8;
    public Text stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8;
    public RectTransform bslot1, bslot2, bslot3, bslot4, bslot5, bslot6, bslot7, bslot8;
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

    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
        conexAl = GameObject.Find("Alcalde").GetComponent<Alcalde>();


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

        //Cuanta activas para que el alcalde te muestre la interfaz o no
        if(activa1||activa2||activa3||activa4||activa5||activa6||activa7||activa8||activa9)
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
    }


    public void ToggleAMisiones()
    {


        mostrar = !mostrar;
        AlcaldeMisionesUI.gameObject.SetActive(mostrar);

        if (mostrar)
        {
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 0f;
        }
        else if (!mostrar)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
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

    



}
