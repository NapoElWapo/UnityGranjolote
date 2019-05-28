using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryInteraction : MonoBehaviour
{
    //Este script lanza un rayo desde el centro de la pantalla
    public Camera MainCamera;
    //54ul
    
    [Header("Propiedades")]
    public string fetch_Tag = "Item";
    public string puertac1 = "Puerta1";
    public string puertac2 = "Puerta2";
    public string puertam = "PuertaM1";
    public string puertach = "PuertaH";
    public string puertacj = "PuertaJ";
    public string puertac11 = "PP1";
    public string puertac22 = "PP2";
    public string puertacmm = "PPM";
    public string puertachh = "PPH";
    public string puertacjj = "PPJ";

    public AjoloteCriadero criadero1, criadero2, criadero3, criadero4, criadero5, criadero6, criadero7, criadero8, criadero9, criadero10;
    public string cria1 = "Criadero1";
    public string cria2 = "Criadero2";
    public string cria3 = "Criadero3";
    public string cria4 = "Criadero4";
    public string cria5 = "Criadero5";
    public string cria6 = "Criadero6";
    public string cria7 = "Criadero7";
    public string cria8 = "Criadero8";
    public string cria9 = "Criadero9";
    public string cria10 = "Criadero10";

    public MejorarAjolote mejorasAjo;
    public string mejoras = "MejorarAjolotes";

    public string cama = "Cama";

    public Incubadora incu;
    public string incubadora1 = "Incubadora1";
    public string incubadora2 = "Incubadora2";
    public string incubadora3 = "Incubadora3";

    public string npc = "NPC";

    public TiendaUI tien;
    public string Tienda = "Tienda";

    public RegistrarAjoloteUI registroUI;
    public string Anaizador = "Analizador";

    public float range = 4;
    public KeyCode key_to_refresh = KeyCode.E;
    public GameObject current_selected_obj; //Deberia de ser un item base
    public GameObject triggernpc;

    public Teleport TP;

    void Start()
    {
        //   controlador_juego = GetComponent<GameMaster>();
        MainCamera = this.GetComponent<Camera>();
        
    }

    void Update()
    {
        RaycastHit colision_rayo;
        Ray rayo = MainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)); //Optimizar screen w,h
        Debug.DrawRay(rayo.origin, rayo.direction * range);
        if (GameMaster.instanciaCompartida.hora == 6)
        {
            GameMaster.instanciaCompartida.cambioVelocidad = 1;
        }
        if (Input.GetButtonDown("e"))
        {
            Debug.Log("pew");
            if (Physics.Raycast(rayo, out colision_rayo, range))
            {
                 //   Debug.Log(colision_rayo.transform.tag);
                if (colision_rayo.transform.tag == fetch_Tag)
                {
                    current_selected_obj = colision_rayo.transform.gameObject;
                    current_selected_obj.SetActive(GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>()));
                }
                else if (colision_rayo.transform.tag == puertac1)
                {
                    TP.CasaNPC1();
                    //el 2 equivale a la escena de pruebas, cambiar el numero para que sea overworld
                }
                else if (colision_rayo.transform.tag == puertac2)
                {
                    TP.CasaNPC2();
                    //cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertam)
                {
                    TP.CasaNPCM();
                    //cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertach)
                {
                    TP.CasaHospital();
                    //cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertacj)
                {
                    TP.CasaJugador();
                    //cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertac11)//puerta de la CasaIP
                {
                    TP.CasaN1O();
                    //el cuatro es la escena CasaIP

                }
                else if (colision_rayo.transform.tag == puertac22)
                {
                    TP.CasaN2O();
                    
                }
                else if (colision_rayo.transform.tag == puertacmm)
                {
                    TP.CasaNMO();
                    
                }
                else if (colision_rayo.transform.tag == puertachh)
                {
                    TP.CasaHO();
                    
                }
                else if (colision_rayo.transform.tag == puertacjj)
                {
                    TP.CasaJO();
                    
                }
                else if (colision_rayo.transform.tag == cama)
                {
                    
                    if (GameMaster.instanciaCompartida.hora >= 18)
                    {
                        
                        
                            GameMaster.instanciaCompartida.cambioVelocidad = 150;
                    }
                    else if (GameMaster.instanciaCompartida.hora < 6)
                    {


                        GameMaster.instanciaCompartida.cambioVelocidad = 150;
                    }

                }
                else if(colision_rayo.transform.tag==Tienda)
                {
                    tien.ToggleTienda();
                }
                //Abrir Incubadoras
                else if (colision_rayo.transform.tag == incubadora1)
                {
                    incu.ToggleIncubadora();
                                   
                }
               
                else  if (colision_rayo.transform.tag == npc)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                            Debug.Log("It's dangerous to go alone! Take this.");
                    }
                }
                else if (colision_rayo.transform.tag == Anaizador)
                {
                    registroUI.ToggleRegistro();
                   
                }

                else if (colision_rayo.transform.tag == cria1)
                {
                    criadero1.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria2)
                {
                    criadero2.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria3)
                {
                    criadero3.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria4)
                {
                    criadero4.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria5)
                {
                    criadero5.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria6)
                {
                    criadero6.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria7)
                {
                    criadero7.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria8)
                {
                    criadero8.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria9)
                {
                    criadero9.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == cria10)
                {
                    criadero10.ToggleCriadero();

                }

                else if (colision_rayo.transform.tag == mejoras)
                {
                    mejorasAjo.ToggleMejoras();

                }
            }
        } 
    }
}
