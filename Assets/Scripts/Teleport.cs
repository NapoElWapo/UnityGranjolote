using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Teleport : MonoBehaviour
{
    public GameObject LCJ, LCN1, LCN2, LCNM, LH, LHM,JO,N1O,N2O,NMO,HO,Player;
    public GameObject sol, luna, luzInterior;
   
    void Start()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        luzInterior = GameObject.Find("LuzInterior").GetComponent<GameObject>();
    }

    void Update()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        if (playerScript.muerto==true)
        {
            sol.gameObject.SetActive(false);
            luna.gameObject.SetActive(false);
            luzInterior.gameObject.SetActive(true);

            Jugador = GameObject.FindWithTag("Player");
            Jugador.SetActive(false);
            Jugador.transform.position = LHM.transform.position;
            Jugador.SetActive(true);
            playerScript.muerto = false;
        }
    }

    public void CasaJugador()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCJ.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPC1()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCN1.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPC2()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCN2.transform.position;
        Player.SetActive(true);
    }

    public void CasaNPCM()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LCNM.transform.position;
        Player.SetActive(true);
    }

    public void CasaHospital()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LH.transform.position;
        Player.SetActive(true);
    }

    public void CasaHospitalMuerte()
    {
        sol.gameObject.SetActive(false);
        luna.gameObject.SetActive(false);
        luzInterior.gameObject.SetActive(true);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = LHM.transform.position;
        Player.SetActive(true);
    }

    public void CasaJO()
    {
        sol.gameObject.SetActive(true);
        luna.gameObject.SetActive(true);
        luzInterior.gameObject.SetActive(false);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = JO.transform.position;
        Player.SetActive(true);
    }

    public void CasaN1O()
    {
        sol.gameObject.SetActive(true);
        luna.gameObject.SetActive(true);
        luzInterior.gameObject.SetActive(false);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = N1O.transform.position;
        Player.SetActive(true);
    }

    public void CasaN2O()
    {
        sol.gameObject.SetActive(true);
        luna.gameObject.SetActive(true);
        luzInterior.gameObject.SetActive(false);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = N2O.transform.position;
        Player.SetActive(true);
    }

    public void CasaNMO()
    {
        sol.gameObject.SetActive(true);
        luna.gameObject.SetActive(true);
        luzInterior.gameObject.SetActive(false);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = NMO.transform.position;
        Player.SetActive(true);
    }

    public void CasaHO()
    {
        sol.gameObject.SetActive(true);
        luna.gameObject.SetActive(true);
        luzInterior.gameObject.SetActive(false);

        Player = GameObject.FindWithTag("Player");
        Player.SetActive(false);
        Player.transform.position = HO.transform.position;
        Player.SetActive(true);
    }
}
