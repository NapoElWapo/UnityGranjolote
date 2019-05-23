using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TiendaUI : MonoBehaviour
{

    public RectTransform  producto1, producto2, producto3, producto4, producto5, producto6, tiendaUI;
    private bool p1=false, p2=false, p3=false, p4=false, p5=false, p6=false,lc=false,ac=false,afc=false,ahc=false,rc=false;
    public GameObject current_selected_obj,lanza,arco,rastrillo,AF,AH,comida;

    public int dinero;
    public Text uiDinero;

    private int ventanaActiva;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uiDinero.text = "Oro : " + GameMaster.instanciaCompartida.dinero;
    }

    public void ToggleTienda()
    {



        GameMaster.instanciaCompartida.mostrarTiendaUI = !GameMaster.instanciaCompartida.mostrarTiendaUI;
        tiendaUI.gameObject.SetActive(GameMaster.instanciaCompartida.mostrarTiendaUI);
        
        if (GameMaster.instanciaCompartida.mostrarTiendaUI==true)
        {
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 0f;
        }
        else if(GameMaster.instanciaCompartida.mostrarTiendaUI == false)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
        }

        
    }

    public void ToggleProducto1()
    {
        if(lc==false)
        {
            p1 = !p1;
            producto1.gameObject.SetActive(p1);
            ventanaActiva = 1;
        }
        
    }

    public void ToggleProducto2()
    {
        if (ac == false)
        {
            p2 = !p2;
            producto2.gameObject.SetActive(p2);
            ventanaActiva = 2;
        }
    }

    public void ToggleProducto3()
    {
        if (rc == false)
        {
            p3 = !p3;
            producto3.gameObject.SetActive(p3);
            ventanaActiva = 3;
        }
    }

    public void ToggleProducto4()
    {
        if (afc == false)
        {
            p4 = !p4;
            producto4.gameObject.SetActive(p4);
            ventanaActiva = 4;
        }
    }

    public void ToggleProducto5()
    {
        if (ahc == false)
        {
            p5 = !p5;
            producto5.gameObject.SetActive(p5);
            ventanaActiva = 5;
        }
    }

    public void ToggleProducto6()
    {
        p6 = !p6;
        producto6.gameObject.SetActive(p6);
        ventanaActiva = 6;
    }

    public void Comprar()
    {
        switch(ventanaActiva)
        {
            case 1:

                if(GameMaster.instanciaCompartida.dinero >= 50&&lc==false)
                {
                    current_selected_obj = lanza.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 50;
                    ToggleProducto1();
                    lc = true;
                   
                }
                

                break;

            case 2:

                if (GameMaster.instanciaCompartida.dinero >= 2000 && ac == false)
                {

                    
                    current_selected_obj = arco.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());

                    GameMaster.instanciaCompartida.dinero -= 2000;
                    ToggleProducto2();
                    ac = true;
                }
                break;

            case 3:

                if (GameMaster.instanciaCompartida.dinero >= 400 && rc == false)
                {
                    current_selected_obj = rastrillo.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 400;
                    ToggleProducto3();
                    rc = true;
                }
                break;

            case 4:

                if (GameMaster.instanciaCompartida.dinero >= 8000 && afc == false)
                {
                    current_selected_obj = AF.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 8000;
                    ToggleProducto4();
                    afc = true;
                }
                break;

            case 5:

                if (GameMaster.instanciaCompartida.dinero >= 12000 && ahc == false)
                {
                    current_selected_obj = AH.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 12000;
                    ToggleProducto5();
                    ahc =true;
                }
                break;

            case 6:

                if (GameMaster.instanciaCompartida.dinero >= 10)
                {
                    current_selected_obj = comida.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    GameMaster.instanciaCompartida.dinero -= 10;
                }
                break;
        }
        
    }

}
