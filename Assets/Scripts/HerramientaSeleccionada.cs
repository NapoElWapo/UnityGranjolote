using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerramientaSeleccionada : MonoBehaviour
{
    public RectTransform bslot1, bslot2, bslot3, bslot4;
    public Image sslot1, sslot2, sslot3, sslot4;
    public GameObject lanza, rastrillo, ajoloteSA, ajoloteSF,fuego,agua;
    private int slotPosition = 0;
    public int estaminaS=0, maxEstaminaS=100;
    private bool hayFuego,hayAgua,lanzaComprobar=false,rastrilloComprobar=false,AAComprobar=false,AFComprobar=false;
    MenuInventario conex;
    [SerializeField]
    slot comprobar;
    
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    void Update()
    {
        CambiarSlotActivo();
        
        if (hayFuego || hayAgua)
        {
            if (estaminaS <= 0)
            {
                estaminaS = 0;
            }
            else
            {
                estaminaS--;
            }
        }
        else if (!hayFuego&&!hayAgua)
        {
            if (estaminaS <= maxEstaminaS)
            {
                estaminaS = estaminaS + 1;
            }
        }

        comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot1");

        if (comprobar.RealItemName == "Lanza")
        {
            
            sslot1.sprite = comprobar.Slot_ui_img.sprite;
           
        }

        comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot2");

        if (comprobar.RealItemName == "Rastrillo")
        {
            
            sslot2.sprite = comprobar.Slot_ui_img.sprite;
           
        }

        comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot3");

        if (comprobar.RealItemName == "AjoloteSAgua")
        {
            
            sslot3.sprite = comprobar.Slot_ui_img.sprite;
            
        }

        comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot4");

        if (comprobar.RealItemName == "AjoloteSFuego")
        {
           
            sslot4.sprite = comprobar.Slot_ui_img.sprite;
            
        }
    }

    private void CambiarSlotActivo()
    {
        if(Input.GetButtonDown("r"))
        {
            slotPosition--;
        }
        else if(Input.GetButtonDown("t"))
        {
            slotPosition++;
        }

        if(slotPosition<0)
        {
            slotPosition = 3;
        }
        else if(slotPosition>3)
        {
            slotPosition = 0;
        }

        switch (slotPosition)
        {
            case 0:

                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot1");

                if (comprobar.RealItemName == "Lanza")
                {
                    lanza.gameObject.SetActive(true);

                }
                bslot1.gameObject.SetActive(true);
                bslot2.gameObject.SetActive(false);
                bslot3.gameObject.SetActive(false);
                bslot4.gameObject.SetActive(false);
                rastrillo.gameObject.SetActive(false);
                ajoloteSA.gameObject.SetActive(false);
                ajoloteSF.gameObject.SetActive(false);

                

                break;
            case 1:
                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot2");

                if (comprobar.RealItemName == "Rastrillo")
                {
                    rastrillo.gameObject.SetActive(true);
                }
                bslot1.gameObject.SetActive(false);
                bslot2.gameObject.SetActive(true);
                bslot3.gameObject.SetActive(false);
                bslot4.gameObject.SetActive(false);
                lanza.gameObject.SetActive(false);
                
                ajoloteSA.gameObject.SetActive(false);
                ajoloteSF.gameObject.SetActive(false);


                break;
            case 2:
                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot3");

                if (comprobar.RealItemName == "AjoloteSAgua")
                {
                    ajoloteSA.gameObject.SetActive(true);

                    if (Input.GetMouseButtonDown(0) && estaminaS != 0)
                    {
                        agua.gameObject.SetActive(true);
                        hayAgua = true;
                    }
                    else if (estaminaS == 0)
                    {
                        agua.gameObject.SetActive(false);
                    }

                    if (Input.GetMouseButtonUp(0))
                    {
                        agua.gameObject.SetActive(false);
                        hayAgua = false;
                    }
                }
                bslot1.gameObject.SetActive(false);
                bslot2.gameObject.SetActive(false);
                bslot3.gameObject.SetActive(true);
                bslot4.gameObject.SetActive(false);
                lanza.gameObject.SetActive(false);
                rastrillo.gameObject.SetActive(false);
                
                ajoloteSF.gameObject.SetActive(false);

                break;
            case 3:
                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot4");
                Debug.Log(comprobar.Slot_ui_img);

                if (comprobar.RealItemName == "AjoloteSFuego")
                {
                    ajoloteSF.gameObject.SetActive(true);

                    if (Input.GetMouseButtonDown(0) && estaminaS != 0)
                    {
                        fuego.gameObject.SetActive(true);
                        hayFuego = true;
                    }
                    else if(estaminaS==0)
                    {
                        fuego.gameObject.SetActive(false);
                    }

                    if (Input.GetMouseButtonUp(0))
                    {
                        fuego.gameObject.SetActive(false);
                        hayFuego = false;
                    }
                }
                bslot1.gameObject.SetActive(false);
                bslot2.gameObject.SetActive(false);
                bslot3.gameObject.SetActive(false);
                bslot4.gameObject.SetActive(true);
                lanza.gameObject.SetActive(false);
                rastrillo.gameObject.SetActive(false);
                ajoloteSA.gameObject.SetActive(false);              
                break;      
        }
    }
}
