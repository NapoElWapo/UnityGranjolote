using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogrosYMisiones : MonoBehaviour
{
    //botones de la interfaz
    public RectTransform panelMisiones, panelLogros;

    //Items que se pueden otorgar al terminar una mision
    public GameObject current_selected_obj, orbeMA, orbeMF, orbeMN;

    //Misiones
    public RectTransform m1, m2, m3, m4, m5, m6, m7, m8, m9, m10;
    int misionesCompletadas;
    public bool m1c, m2c, m3c, m4c, m5c, m6c, m7c, m8c, m9c, m10c;

    //Booleanos externos
    public bool mision3Alcalde = false;

    //m1
    public bool alimenteAjolote = false;

    //m3
    public int contadorTotalPeces;
    public int contadorL,contadorA,contadorConsecutivo;

    //m4
    public bool pantalonEntregado = false,recompensaOA=false;

    //m5
    public bool sacoEntregado = false,recompensaOF=false;

    //m6
    public bool sombreroEntregado = false,recompensaON=false;

    //m7
    public bool quemado=false,huevoPEntregado=false,huevoAEntregado=false;

    //m8
    public bool congelado=false,cacasFEntregadas=false;

    //m9
    public bool primerACapturado = false, primerPCapturado = false, primerFCapturado=false,primerAEntregado=false,primerPEntregado=false,primerFEntregado=false;
    private bool recompensa=false;
    //Logros
    public RectTransform L1, L2, L3, L4, L5, L6, L7, L8, L9, L10,
        L11, L12, L13, L14, L15, L16, L17, L18, L19, L20,
        L21, L22, L23, L24, L25, L26, L27, L28, L29, L30,
        L31, L32, L33, L34;
    int logrosCompletados;

    //Objetos de scripts diferentes para tomar informacion
    MenuInventario conexMI;
    Incubadora conexIncu;

    void Start()
    {
        //Se hacen las conexiones directas a las variables de los scripts
        conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexIncu = GameObject.Find("Incubadora").GetComponent<Incubadora>();

        //Misiones no disponibles al inicio
        m2.gameObject.SetActive(false);
        m3.gameObject.SetActive(false);
        m4.gameObject.SetActive(false);
        m5.gameObject.SetActive(false);
        m6.gameObject.SetActive(false);
        m7.gameObject.SetActive(false);
        m8.gameObject.SetActive(false);
        m9.gameObject.SetActive(false);
        m10.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        

        //Mision1
        if(alimenteAjolote)
        {
            m1c = true;
            m1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            m2.gameObject.SetActive(true);
        }

        //Mision2
        if(m1c)
        {
            if (conexMI.r1 && conexMI.r2 && conexMI.r3 && conexMI.r4 && conexMI.r5)
            {
                m2c = true;
                m2.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            }
        }
        
        //Mision3
        contadorTotalPeces = contadorL + contadorA;
        if(contadorTotalPeces>=50)
        {
            m3.gameObject.SetActive(true);
            mision3Alcalde = true;
            
        }
      if(mision3Alcalde&&contadorConsecutivo==10)
        {
            m3c = true;
            m3.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        //Mision4
        foreach (var iterador in conexMI.herramientas)
        {
            if(iterador.Is_used)
            {
                if(iterador.RealItemName=="AjoloteSAgua")
                {
                    m4.gameObject.SetActive(true);
                }
            }
        }
        if(pantalonEntregado)
        {
            m4c = true;
            m4.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (m4c && !recompensaOA)
            {
                current_selected_obj = orbeMA.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                recompensaOA = true;
            }
        }
        //Mision5
        foreach (var iterador in conexMI.herramientas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSFuego")
                {
                    m5.gameObject.SetActive(true);
                }
            }
        }
        if (sacoEntregado)
        {
            m5c = true;
            m5.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (m5c && !recompensaOF)
            {
                current_selected_obj = orbeMF.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                recompensaOF = true;
            }
        }
        //Mision6
        foreach (var iterador in conexMI.pasivas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSNube")
                {
                    m6.gameObject.SetActive(true);
                }
            }
        }
        if (sombreroEntregado)
        {
            m6c = true;
            m6.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (m6c && !recompensaON)
            {
                current_selected_obj = orbeMN.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                recompensaON = true;
            }
        }
        //Mision7
        if (quemado)
        {
            m7.gameObject.SetActive(true);
            if(huevoAEntregado&&huevoPEntregado)
            {
                m7c = true;
                m7.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            }
        }
        //Mision8
        if (congelado)
        {
            m8.gameObject.SetActive(true);
            if(cacasFEntregadas)
            {
                m8c = true;
                m8.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            }
        }
        //Mision9
        foreach(var iterador in conexMI.ajolotes)
        {
            if(iterador.Is_used)
            {
                if(iterador.RealItemName=="AjoloteDePlanta")
                {
                    primerPCapturado = true;
                }
                else if (iterador.RealItemName == "AjoloteDeAgua")
                {
                    primerACapturado = true;
                }
                else if (iterador.RealItemName == "AjoloteDeFuego")
                {
                    primerFCapturado = true;
                }
            }

        }
        if(primerPCapturado&&primerACapturado&&primerFCapturado)
        {
            m9.gameObject.SetActive(true);
            if (primerPEntregado && primerAEntregado && primerFEntregado)
            {
                m9c = true;
                m9.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                
                if(m9c&&!recompensa)
                {
                    GameMaster.instanciaCompartida.dinero += 1000;
                    recompensa = true;
                }
                    
                    
                
                
                
            }
        }
        //Mision10
        if(m2c)
        {
            m10.gameObject.SetActive(true);
            if(conexMI.r7)
            {
                m10c = true;
                m10.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            }
        }

        //Logro1
        if(conexMI.r1)
        {
            L1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }

        //Logro2

        //Logro3

        //Logro4

        //Logro5



    }

    public void BotonMisiones()
    {
        panelMisiones.gameObject.SetActive(true);
        panelLogros.gameObject.SetActive(false);
    }

    public void BotonLogros()
    {
        panelMisiones.gameObject.SetActive(false);
        panelLogros.gameObject.SetActive(true);
    }

   


}
