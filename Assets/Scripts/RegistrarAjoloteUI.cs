using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class RegistrarAjoloteUI : MonoBehaviour
{
    [SerializeField]
    slot ajoslot1, ajoslot2, ajoslot3, ajoslot4;
    public Image sslot1, sslot2, sslot3, sslot4;
    public RectTransform bslot1, bslot2, bslot3, bslot4,RegistroUI;
    private int slotSeleccionado = 0;
    private bool ui = false;
    MenuInventario conex;
    public Text mensaje;

    // Start is called before the first frame update
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    // Update is called once per frame
    void Update()
    {
        ajoslot1 = conex.ajolotes.Find(x => x.Slot_name == "Slot1");
        sslot1.sprite = ajoslot1.Slot_ui_img.sprite;

        ajoslot2 = conex.ajolotes.Find(x => x.Slot_name == "Slot2");
        sslot2.sprite = ajoslot2.Slot_ui_img.sprite;

        ajoslot3 = conex.ajolotes.Find(x => x.Slot_name == "Slot3");
        sslot3.sprite = ajoslot3.Slot_ui_img.sprite;

        ajoslot4 = conex.ajolotes.Find(x => x.Slot_name == "Slot4");
        sslot4.sprite = ajoslot4.Slot_ui_img.sprite;
    }

    public void Seleccionar1()
    {
        slotSeleccionado = 1;
        bslot1.gameObject.SetActive(true);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
    }

    public void Seleccionar2()
    {
        slotSeleccionado = 2;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(true);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(false);
    }

    public void Seleccionar3()
    {
        slotSeleccionado = 3;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(true);
        bslot4.gameObject.SetActive(false);
    }

    public void Seleccionar4()
    {
        slotSeleccionado = 4;
        bslot1.gameObject.SetActive(false);
        bslot2.gameObject.SetActive(false);
        bslot3.gameObject.SetActive(false);
        bslot4.gameObject.SetActive(true);
    }

    public void Registrar()
    {
        switch(slotSeleccionado)
        {
            case 1:

                if(ajoslot1.RealItemName=="AjoloteDePlanta" && conex.r1==false)
                {
                   
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 100;
                    conex.r1 = true;
                }
                else if(ajoslot1.RealItemName == "AjoloteDeAgua" && conex.r2 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 400;
                    conex.r2 = true;
                }
                else if (ajoslot1.RealItemName == "AjoloteDeFuego" && conex.r3 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 1000;
                    conex.r3 = true;
                }
                else if (ajoslot1.RealItemName == "AjoloteDeHielo" && conex.r4 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 3000;
                    conex.r4 = true;
                }
                else if (ajoslot1.RealItemName == "AjoloteDeNube" && conex.r5 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 8000;
                    conex.r5 = true;
                }
                else if (ajoslot1.RealItemName == "AjoloteDeOro" && conex.r6 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 7777;
                    conex.r6 = true;
                }
                else if (ajoslot1.RealItemName == "AjoloteLegendario" && conex.r7 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 10000;
                    conex.r7 = true;
                }
                else if(ajoslot1.RealItemName==null)
                {
                    mensaje.text = "Selecciona un ajolote";
                }
                else
                {
                    mensaje.text = "Especie ya registrada";
                }


                break;

            case 2:
                if (ajoslot2.RealItemName == "AjoloteDePlanta" && conex.r1 == false)
                {
                   
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 100;
                    conex.r1 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteDeAgua" && conex.r2 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 400;
                    conex.r2 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteDeFuego" && conex.r3 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 1000;
                    conex.r3 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteDeHielo" && conex.r4 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 3000;
                    conex.r4 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteDeNube" && conex.r5 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 8000;
                    conex.r5 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteDeOro" && conex.r6 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 7777;
                    conex.r6 = true;
                }
                else if (ajoslot2.RealItemName == "AjoloteLegendario" && conex.r7 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 10000;
                    conex.r7 = true;
                }
                else if (ajoslot2.RealItemName == null)
                {
                    mensaje.text = "Selecciona un ajolote";
                }
                else
                {
                    mensaje.text = "Especie ya registrada";
                }

                break;

            case 3:

                if (ajoslot3.RealItemName == "AjoloteDePlanta" && conex.r1 == false)
                {
                   
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 100;
                    conex.r1 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteDeAgua" && conex.r2 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 400;
                    conex.r2 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteDeFuego" && conex.r3 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 1000;
                    conex.r3 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteDeHielo" && conex.r4 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 3000;
                    conex.r4 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteDeNube" && conex.r5 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 8000;
                    conex.r5 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteDeOro" && conex.r6 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 7777;
                    conex.r6 = true;
                }
                else if (ajoslot3.RealItemName == "AjoloteLegendario" && conex.r7 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 10000;
                    conex.r7 = true;
                }
                else if (ajoslot3.RealItemName == null)
                {
                    mensaje.text = "Selecciona un ajolote";
                }
                else
                {
                    mensaje.text = "Especie ya registrada";
                }

                break;

            case 4:

                if (ajoslot4.RealItemName == "AjoloteDePlanta" && conex.r1 == false)
                {
                    
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 100;
                    conex.r1 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteDeAgua" && conex.r2 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 400;
                    conex.r2 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteDeFuego" && conex.r3 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 1000;
                    conex.r3 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteDeHielo" && conex.r4 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 3000;
                    conex.r4 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteDeNube" && conex.r5 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 8000;
                    conex.r5 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteDeOro" && conex.r6 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 7777;
                    conex.r6 = true;
                }
                else if (ajoslot4.RealItemName == "AjoloteLegendario" && conex.r7 == false)
                {
                    mensaje.text = "Nueva especie Registrada";
                    GameMaster.instanciaCompartida.dinero = GameMaster.instanciaCompartida.dinero + 10000;
                    conex.r7 = true;
                }
                else if (ajoslot4.RealItemName == null)
                {
                    mensaje.text = "Selecciona un ajolote";
                }
                else
                {
                    mensaje.text = "Especie ya registrada";
                }

                break;
        }
    }

    public void ComprobarRegistro()
    {
        

        
    }

    public void ToggleRegistro()
    {
        ui = !ui;
        RegistroUI.gameObject.SetActive(ui);
        mensaje.text = "Seleccione un ajolote";

        if (ui == true)
        {
            Cursor.lockState = CursorLockMode.None;

            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 0f;
        }
        else if (ui == false)
        {
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
        }
    }
}
