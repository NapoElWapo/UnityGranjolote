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
    public string letrero = "Letrero";
    public string tienda = "Tienda";
    public string puertac1 = "Puerta1";
    public string puertac2 = "Puerta2";
    public string puertam = "PuertaM1";
    public string puertach = "PuertaH";
    public string puertacj = "PuertaJ";
    public string puertac11 = "PP1";//Tag de la puerta en la escena CasaIP (debes de crear las demas)
    public string puertac22 = "PP2";
    public string puertacmm = "PPM";
    public string puertachh = "PPH";
    public string puertacjj = "PPJ";
  
    public float range = 4;
    public KeyCode key_to_refresh = KeyCode.E;
    public GameObject current_selected_obj; //Deberia de ser un item base
    public GameObject Letrero;



    
    // Start is called before the first frame update
    void Start()
    {
        //   controlador_juego = GetComponent<GameMaster>();
        MainCamera = this.GetComponent<Camera>();
        Letrero = GameObject.FindWithTag("Letrero");
        Letrero.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit colision_rayo;
        Ray rayo = MainCamera.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2 , 0)); //Optimizar screen w,h
        Debug.DrawRay(rayo.origin, rayo.direction* range);
        if (Input.GetButtonDown("e"))
        {
            Debug.Log("pew");
            if (Physics.Raycast(rayo, out colision_rayo, range))
            {
                    Debug.Log(colision_rayo.transform.tag);
                if (colision_rayo.transform.tag == fetch_Tag)
                {
                    current_selected_obj = colision_rayo.transform.gameObject;
                    current_selected_obj.SetActive(false);

                    //load to the store mangaer and refresh the UI
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj.GetComponent<ItemInventario>());
                }

                else if (colision_rayo.transform.tag == puertac1)
                {
                    GameMaster.instanciaCompartida.Casa1();
                    GameMaster.instanciaCompartida.nivelanterior = 1;//el 2 equivale a la escena de pruebas, cambiar el numero para que sea overworld
                }
                else if (colision_rayo.transform.tag == puertac2)
                {
                    GameMaster.instanciaCompartida.Casa2();
                    GameMaster.instanciaCompartida.nivelanterior = 1;//cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertam)
                {
                    GameMaster.instanciaCompartida.CasaMision();
                    GameMaster.instanciaCompartida.nivelanterior = 1;//cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertach)
                {
                    GameMaster.instanciaCompartida.CasaHospital();
                    GameMaster.instanciaCompartida.nivelanterior = 1;//cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertacj)
                {
                    GameMaster.instanciaCompartida.CasaJugador();
                    GameMaster.instanciaCompartida.nivelanterior = 1;//cambio a overworld

                }
                else if (colision_rayo.transform.tag == puertac11)//puerta de la CasaIP
                {
                    GameMaster.instanciaCompartida.Jugar();
                    GameMaster.instanciaCompartida.nivelanterior = 4;//el cuatro es la escena CasaIP

                }
                else if (colision_rayo.transform.tag == puertac22)
                {
                    GameMaster.instanciaCompartida.Jugar();
                    GameMaster.instanciaCompartida.nivelanterior = 5;
                }
                else if (colision_rayo.transform.tag == puertacmm)
                {
                    GameMaster.instanciaCompartida.Jugar();
                    GameMaster.instanciaCompartida.nivelanterior = 6;
                }
                else if (colision_rayo.transform.tag == puertachh)
                {
                    GameMaster.instanciaCompartida.Jugar();
                    GameMaster.instanciaCompartida.nivelanterior = 3;
                }
                else if (colision_rayo.transform.tag == puertacjj)
                {
                    GameMaster.instanciaCompartida.Jugar();
                    GameMaster.instanciaCompartida.nivelanterior = 7;
                }
                   
            }
                
        }
        if (Physics.Raycast(rayo, out colision_rayo, range))
        {
            if (colision_rayo.transform.tag == tienda)
            {
                void OnTriggerStay()
                {
                    Letrero = GameObject.FindWithTag("Letrero");
                    Letrero.SetActive(true);
                }
                void OnTriggerExit()
                {
                    Letrero = GameObject.FindWithTag("Letrero");
                    Letrero.SetActive(false);
                }
            }
            
        }
    }
}
