﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Teleport : MonoBehaviour
{

    public GameObject LCJ, LCN1, LCN2, LCNM, LH, LHM,JO,N1O,N2O,NMO,HO,Player;
   
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        if (playerScript.muerto==true)
        {
            Debug.Log("Me muerooooo");
            
            Jugador = GameObject.FindWithTag("Player");
            Jugador.SetActive(false);
            Jugador.transform.position = LHM.transform.position;
            Jugador.SetActive(true);
            playerScript.muerto = false;
        }
    }

    public void CasaJugador()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCJ.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPC1()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCN1.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPC2()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCN2.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPCM()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCNM.transform.position;
        Player.SetActive(true);
    }

    public void CasaHospital()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LH.transform.position;
        Player.SetActive(true);
    }

    public void CasaHospitalMuerte()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LHM.transform.position;
        Player.SetActive(true);
    }

    public void CasaJO()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = JO.transform.position;
        Player.SetActive(true);
    }

    public void CasaN1O()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = N1O.transform.position;
        Player.SetActive(true);
    }

    public void CasaN2O()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = N2O.transform.position;
        Player.SetActive(true);
    }

    public void CasaNMO()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = NMO.transform.position;
        Player.SetActive(true);
    }

    public void CasaHO()
    {

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = HO.transform.position;
        Player.SetActive(true);
    }

}