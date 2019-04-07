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
    public string fetch_Tag = "Item ";
    public float range = 4;
   


    // Start is called before the first frame update
    void Start()
    {
        controlador_juego = GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit colision_rayo;
        Ray rayo = MainCamera.ScreenPointToRay(new Vector3(Screen.width/2,Screen.height/2 , 0));
        Debug.DrawRay(rayo.origin, rayo.direction*100);
        if (Input.GetButtonDown("Fire1"))
        {
          
            if (Physics.Raycast(rayo, out colision_rayo))
                Debug.Log(colision_rayo.transform.name);
        }
    }
}
