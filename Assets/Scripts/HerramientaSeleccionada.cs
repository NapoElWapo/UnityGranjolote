using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class HerramientaSeleccionada : MonoBehaviour
{
    public RectTransform bslot1, bslot2, bslot3, bslot4;
    public Image sslot1, sslot2, sslot3, sslot4;
    public GameObject lanza, arco,rastrillo, ajoloteSA, ajoloteSF,fuego,agua,lanzaClick1,lanzaClick2,arcoClick,flechaClick1,flechaClick2,rastrillo1;
    private int slotPosition = 0;
    public int estaminaS=0, maxEstaminaS=100,nivelAgua=1,nivelFuego=1,nivelNube=1;
    private bool hayFuego,hayAgua,lanzaComprobar=false,rastrilloComprobar=false,AAComprobar=false,AFComprobar=false,lanzaPesaca=false,arcoPesca=false,rastrilloGusano=false;
    MenuInventario conex;
    [SerializeField]
    slot comprobar,nube;
    
    void Start()
    {
        conex = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    void Update()
    {
        
        
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

        if (comprobar.RealItemName == "Lanza"||comprobar.RealItemName=="Arco")
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

        nube = conex.pasivas.Find(x => x.Slot_name == "Slot2");
        if (nube.RealItemName == "AjoloteSNube")
        {
            
            GameObject Jugador = GameObject.FindWithTag("Player");
            FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
            playerScript.saltos = nivelNube;

        }
        CambiarSlotActivo();

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


                bslot1.gameObject.SetActive(true);
                bslot2.gameObject.SetActive(false);
                bslot3.gameObject.SetActive(false);
                bslot4.gameObject.SetActive(false);
                rastrillo.gameObject.SetActive(false);
                ajoloteSA.gameObject.SetActive(false);
                ajoloteSF.gameObject.SetActive(false);
                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot1");



                if (comprobar.RealItemName == "Lanza")
                {
                    if(lanzaPesaca==false)
                    {
                        lanza.gameObject.SetActive(true);
                        arco.gameObject.SetActive(false);
                    }
                    


                    if (Input.GetMouseButtonDown(1))
                    {


                        lanzaPesaca = true;
                        StartCoroutine(animacionLanza());
                        
                    }

                }
                else if(comprobar.RealItemName == "Arco")
                {

                    if (arcoPesca == false)
                    {
                        lanza.gameObject.SetActive(false);
                        arco.gameObject.SetActive(true);
                    }
                    if (Input.GetMouseButtonDown(1))
                    {


                        arcoPesca = true;
                        StartCoroutine(animacionArco());

                    }
                }
               

                

                break;
            case 1:
                comprobar = conex.herramientas.Find(x => x.Slot_name == "Slot2");

                if (comprobar.RealItemName == "Rastrillo")
                {
                    if(rastrilloGusano==false)
                    {
                        rastrillo.gameObject.SetActive(true);
                    }

                    if (Input.GetMouseButtonDown(1))
                    {


                        rastrilloGusano = true;
                        StartCoroutine(animacionRastrillo());

                    }

                }
                bslot1.gameObject.SetActive(false);
                bslot2.gameObject.SetActive(true);
                bslot3.gameObject.SetActive(false);
                bslot4.gameObject.SetActive(false);
                lanza.gameObject.SetActive(false);
                
                ajoloteSA.gameObject.SetActive(false);
                ajoloteSF.gameObject.SetActive(false);
                arco.gameObject.SetActive(false);

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
                arco.gameObject.SetActive(false);
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
                arco.gameObject.SetActive(false);
                break;      
        }
    }

    IEnumerator animacionLanza()
    {
        lanza.gameObject.SetActive(false);
        lanzaClick1.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        lanzaClick1.gameObject.SetActive(false);
        lanzaClick2.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        lanzaClick1.gameObject.SetActive(true);
        lanzaClick2.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lanzaClick1.gameObject.SetActive(false);
        lanza.gameObject.SetActive(true);
        lanzaPesaca = false;

    }

    IEnumerator animacionArco()
    {
        arco.gameObject.SetActive(false);
        arcoClick.gameObject.SetActive(true);
        flechaClick1.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        flechaClick1.gameObject.SetActive(false);
        flechaClick2.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        flechaClick1.gameObject.SetActive(true);
        flechaClick2.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        flechaClick1.gameObject.SetActive(false);
        arcoClick.gameObject.SetActive(false);
        arco.gameObject.SetActive(true);
        arcoPesca = false;

    }

    IEnumerator animacionRastrillo()
    {
        rastrillo.gameObject.SetActive(false);
        rastrillo1.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        
        
        rastrillo1.gameObject.SetActive(false);
        rastrillo.gameObject.SetActive(rastrillo);
        
        rastrilloGusano = false;

    }
}
