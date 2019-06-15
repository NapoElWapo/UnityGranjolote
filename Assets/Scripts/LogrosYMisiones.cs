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

    //Logros de ajolotes maxeados
    public bool MaxAgua = false, MaxFuego = false, MaxNube = false;

    //Logro30 31
    public int contadorGusanos;

    //Logro 32 33
    public int criaderosComprados;

    //Objetos de scripts diferentes para tomar informacion
    MenuInventario conexMI;
    Incubadora conexIncu;
    AlcaldeMisiones conexAM;
    public AjoloteCriadero bool1, bool2, bool3, bool4, bool5, bool6, bool7, bool8, bool9, bool10;

    //Variables de notificaciones
    Notificaciones conexN;
    private bool popm1, popm2, popm3, popm4, popm5, popm6, popm7, popm8, popm9, popm10, popl1, popl2, popl3, popl4, popl5, popl6, popl7, popl8, popl9, popl10, popl11, popl12, popl13, popl14,
        popl15, popl16, popl17, popl18, popl19, popl20, popl21, popl22, popl23, popl24, popl25, popl26, popl27, popl28, popl29, popl30, popl31, popl32, popl33, popl34,
        popa3,popa4,popa5,popa6,popa7,popa8,popa9;

    public Image barra1, barra2, barra3, barra4, barra5, barra6, barra7, barra8, barra9, barra10, barra11, barra12, barra13, barra14;

    void Start()
    {
        //Se hacen las conexiones directas a las variables de los scripts
        
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

        conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
        conexIncu = GameObject.Find("Incubadora").GetComponent<Incubadora>();
        conexAM = GameObject.Find("AlcaldeMisiones").GetComponent<AlcaldeMisiones>();
        conexN = GameObject.Find("NotificacionesDeslizantes").GetComponent<Notificaciones>();
        Debug.LogError("el start funciona2");
    }

    // Update is called once per frame
    void Update()
    {
        

        //Mision1
        if(alimenteAjolote)
        {
            m1c = true;
            if(popm1==false)
            {
                conexN.popM();
                conexN.popA();
                popm1 = true;
            }
            
            m1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            
            conexAM.activa1 = true;
            //m2.gameObject.SetActive(true);
        }

        //Mision2
        if(m1c)
        {
            if (conexMI.r1 && conexMI.r2 && conexMI.r3 && conexMI.r4 && conexMI.r5)
            {
                m2c = true;
                if (popm2 == false)
                {
                    conexN.popM();
                    conexN.popA();
                    popm2 = true;
                }
                conexAM.activa9 = true;
                conexAM.activa1 = false;
                m2.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            }
        }
        
        //Mision3
        contadorTotalPeces = contadorL + contadorA;
        if(contadorTotalPeces>=50)
        {
            //m3.gameObject.SetActive(true);
            if (popa3 == false)
            {
                conexN.popA();
                popa3 = true;
            }
            conexAM.activa2 = true;
            //mision3Alcalde = true;
            
        }
      if(mision3Alcalde&&contadorConsecutivo==10)
        {
            m3c = true;
            if (popm3 == false)
            {
                conexN.popM();
                conexN.popO();
                popm3 = true;
            }
            conexAM.activa2 = false;
            m3.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        //Mision4
        foreach (var iterador in conexMI.herramientas)
        {
            if(iterador.Is_used)
            {
                if(iterador.RealItemName=="AjoloteSAgua")
                {
                    //m4.gameObject.SetActive(true);
                    if (popa4 == false)
                    {
                        conexN.popA();
                        popa4 = true;
                    }
                    conexAM.activa3 = true;
                }
            }
        }
        if(pantalonEntregado)
        {
            m4c = true;
            if (popm4 == false)
            {
                conexN.popM();
                popm4 = true;
            }
            m4.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            conexAM.activa3 = false;
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
                    //m5.gameObject.SetActive(true);
                    if (popa5 == false)
                    {
                        conexN.popA();
                        popa5 = true;
                    }
                    conexAM.activa4 = true;
                }
            }
        }
        if (sacoEntregado)
        {
            m5c = true;
            if (popm5 == false)
            {
                conexN.popM();
                popm5 = true;
            }
            m5.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            conexAM.activa4 = false;
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
                    //m6.gameObject.SetActive(true);
                    if (popa6 == false)
                    {
                        conexN.popA();
                        popa6 = true;
                    }
                    conexAM.activa5 = true;
                }
            }
        }
        if (sombreroEntregado)
        {
            m6c = true;
            if (popm6 == false)
            {
                conexN.popM();
                popm6 = true;
            }
            m6.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            conexAM.activa5 = false;
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
            //m7.gameObject.SetActive(true);
            if (popa7 == false)
            {
                conexN.popA();
                popa7 = true;
            }
            conexAM.activa6 = true;
            if(huevoAEntregado&&huevoPEntregado)
            {
                m7c = true;
                if (popm7 == false)
                {
                    conexN.popM();
                    popm7 = true;
                }
                m7.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                conexAM.activa6 = false;
            }
        }
        //Mision8
        if (congelado)
        {
            //m8.gameObject.SetActive(true);
            conexAM.activa7 = true;
            if (popa8 == false)
            {
                conexN.popA();
                popa8 = true;
            }
            if (cacasFEntregadas)
            {
                m8c = true;
                if (popm8 == false)
                {
                    conexN.popM();
                    popm8 = true;
                }
                m8.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                conexAM.activa7 = false;
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
            //m9.gameObject.SetActive(true);
            conexAM.activa8 = true;
            if (popa9 == false)
            {
                conexN.popA();
                popa9 = true;
            }
            if (primerPEntregado && primerAEntregado && primerFEntregado)
            {
                m9c = true;
                if (popm9 == false)
                {
                    conexN.popM();
                    popm9 = true;
                }
                m9.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                conexAM.activa8 = false;
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
            
            //m10.gameObject.SetActive(true);
            if (conexMI.r7)
            {
                m10c = true;
                if (popm10 == false)
                {
                    conexN.popM();
                    popm10 = true;
                }
                m10.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                conexAM.activa9 = false;
            }
        }

        //Logro1
        if(conexMI.r1)
        {
            L1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl1 == false)
            {
                conexN.popL();
                popl1 = true;
            }
        }

        //Logro2
        if(conexIncu.primerP)
        {
            L2.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl2 == false)
            {
                conexN.popL();
                popl2 = true;
            }
        }

        //Logro3
        if(conexMI.contador10AjoP>=10)
        {
            L3.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl3 == false)
            {
                conexN.popL();
                popl3 = true;
            }
        }


        //Logro4
        if (conexMI.r2)
        {
            L4.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl4 == false)
            {
                conexN.popL();
                popl4 = true;
            }
        }

        //Logro5
        if (conexIncu.primerA)
        {
            L5.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl5 == false)
            {
                conexN.popL();
                popl5 = true;
            }
        }

        //Logro6
        if (conexMI.contador10AjoA >= 10)
        {
            L6.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl6 == false)
            {
                conexN.popL();
                popl6 = true;
            }
        }
        //Logro7
        if (conexMI.r3)
        {
            L7.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl7 == false)
            {
                conexN.popL();
                popl7 = true;
            }
        }

        //Logro8
        if (conexIncu.primerF)
        {
            L8.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl8 == false)
            {
                conexN.popL();
                popl8 = true;
            }
        }

        //Logro9
        if (conexMI.contador10AjoF >= 10)
        {
            L9.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl9 == false)
            {
                conexN.popL();
                popl9 = true;
            }
        }

        //Logro10
        if (conexMI.r4)
        {
            L10.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl10 == false)
            {
                conexN.popL();
                popl10 = true;
            }
        }

        //Logro11
        if (conexIncu.primerH)
        {
            L11.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl11 == false)
            {
                conexN.popL();
                popl11 = true;
            }
        }

        //Logro12
        if (conexMI.contador10AjoH >= 10)
        {
            L12.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl12 == false)
            {
                conexN.popL();
                popl12 = true;
            }
        }

        //Logro13
        if (conexMI.r5)
        {
            L13.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl13 == false)
            {
                conexN.popL();
                popl13 = true;
            }
        }

        //Logro14
        if (conexIncu.primerN)
        {
            L14.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl14 == false)
            {
                conexN.popL();
                popl14 = true;
            }
        }

        //Logro15
        if (conexMI.contador10AjoN >= 10)
        {
            L15.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl15 == false)
            {
                conexN.popL();
                popl15 = true;
            }
        }

        //Logro16
        if (conexMI.r6)
        {
            L16.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl16 == false)
            {
                conexN.popL();
                popl16 = true;
            }
        }

        //Logro17
        if (conexIncu.primerO)
        {
            L17.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl17 == false)
            {
                conexN.popL();
                popl17 = true;
            }
        }

        //Logro18
        if (conexMI.contador10AjoO >= 10)
        {
            L18.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl18 == false)
            {
                conexN.popL();
                popl18 = true;
            }
        }

        //Logro19
        if (conexMI.r7)
        {
            L19.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl19 == false)
            {
                conexN.popL();
                popl19 = true;
            }
        }

        //Logro20
        if (conexMI.r8)
        {
            L20.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl20 == false)
            {
                conexN.popL();
                popl20 = true;
            }
        }

        //Logro21
        if(MaxAgua)
        {
            L21.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl21 == false)
            {
                conexN.popL();
                popl21 = true;
            }
        }

        //Logro22
        if (conexMI.r9)
        {
            L22.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl22 == false)
            {
                conexN.popL();
                popl22 = true;
            }
        }

        //Logro23
        if (MaxFuego)
        {
            L23.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl23 == false)
            {
                conexN.popL();
                popl23 = true;
            }
        }

        //Logro24
        if (conexMI.r10)
        {
            L24.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl24 == false)
            {
                conexN.popL();
                popl24 = true;
            }
        }

        //Logro25
        if (MaxNube)
        {
            L25.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl25 == false)
            {
                conexN.popL();
                popl25 = true;
            }
        }

        //Logro26
        if(contadorTotalPeces>=15)
        {
            L26.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl26 == false)
            {
                conexN.popL();
                popl26 = true;
            }
        }

        //Logro27
        if(contadorL>=100)
        {
            L27.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl27 == false)
            {
                conexN.popL();
                popl27 = true;
            }
        }

        //Logro28
        if (contadorA >= 100)
        {
            L28.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl28 == false)
            {
                conexN.popL();
                popl28 = true;
            }
        }

        //Logro29
        if (contadorTotalPeces >= 500)
        {
            L29.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl29 == false)
            {
                conexN.popL();
                popl29 = true;
            }
        }

        //Logro30
        if(contadorGusanos>=15)
        {
            L30.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl30 == false)
            {
                conexN.popL();
                popl30 = true;
            }
        }
        //Logro31
        if (contadorGusanos >= 50)
        {
            L31.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl31 == false)
            {
                conexN.popL();
                popl31 = true;
            }
        }

        //Logro32
        if (criaderosComprados >= 2)
        {
            L32.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl32 == false)
            {
                conexN.popL();
                popl32 = true;
            }
        }

        //Logro33
        if (criaderosComprados == 10)
        {
            L33.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl33 == false)
            {
                conexN.popL();
                popl33 = true;
            }
        }

        //Logro34
        if(bool1.criaderoLleno&& bool2.criaderoLleno && bool3.criaderoLleno && bool4.criaderoLleno && bool5.criaderoLleno && bool6.criaderoLleno && bool7.criaderoLleno && bool8.criaderoLleno && bool9.criaderoLleno && bool10.criaderoLleno)
        {
            L34.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            if (popl34 == false)
            {
                conexN.popL();
                popl34 = true;
            }
        }
        barra1.fillAmount = conexMI.contador10AjoP*0.1f;
        barra2.fillAmount = conexMI.contador10AjoA * 0.1f;
        barra3.fillAmount = conexMI.contador10AjoF * 0.1f;
        barra4.fillAmount = conexMI.contador10AjoH * 0.1f;
        barra5.fillAmount = conexMI.contador10AjoN * 0.1f;
        barra6.fillAmount = conexMI.contador10AjoO * 0.1f;
        barra7.fillAmount = contadorTotalPeces * 0.067f;
        barra8.fillAmount = contadorL * 0.01f;
        barra9.fillAmount = contadorA * 0.01f;
        barra10.fillAmount = contadorTotalPeces * 0.002f;
        barra11.fillAmount = contadorGusanos * 0.1f;
        barra12.fillAmount = contadorGusanos * 0.02f;
        barra13.fillAmount = criaderosComprados * 0.1f;
        barra14.fillAmount = (bool1.criaderollenito + bool2.criaderollenito + bool3.criaderollenito + bool4.criaderollenito + bool5.criaderollenito + bool6.criaderollenito + bool7.criaderollenito + bool8.criaderollenito + bool9.criaderollenito + bool10.criaderollenito) * 0.1f;
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
