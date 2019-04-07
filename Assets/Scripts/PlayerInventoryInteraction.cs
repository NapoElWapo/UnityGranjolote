using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerInventoryInteraction : MonoBehaviour
{
    //Este script lanza un rayo desde el centro de la pantalla
    public GameMaster controlador_juego;
    public Camera MainCamera;
    //54ul
    
    [Header("Propiedades")]
    public string fetch_Tag = "Item";
    public float range = 4;
    public KeyCode key_to_refresh = KeyCode.E;
    public GameObject current_selected_obj; //Deberia de ser un item base



    
    // Start is called before the first frame update
    void Start()
    {
        //   controlador_juego = GetComponent<GameMaster>();
        MainCamera = this.GetComponent<Camera>();
        controlador_juego = FindObjectOfType<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit colision_rayo;
        Ray rayo = MainCamera.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2 , 0)); //Optimizar screen w,h
        Debug.DrawRay(rayo.origin, rayo.direction* range);
        if (Input.GetKeyDown(key_to_refresh))
        {

            if (Physics.Raycast(rayo, out colision_rayo, range))
            {

                
                    Debug.Log(colision_rayo.transform.tag);
                    if(colision_rayo.transform.tag == fetch_Tag)
                {

                    current_selected_obj = colision_rayo.transform.gameObject;

                }

            }
                
        }
    }
}
