using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinijuegoPescaArco : MonoBehaviour
{
    public AudioSource sonidosPesca;
    public AudioClip fallo, exito;

    public RectTransform pez, posFinal, panelPesca, holder;

    private Vector2 posInicio;
    public float vel = 300;
    public bool pescarOrbe;
    public GameObject pescado, current_selected_obj,orbeF;
    public int contadorPecesA=0;
    LogrosYMisiones contador;
    public OrbeArco OrbeArcoB;
    private void OnEnable()
    {
        /*
        pez = pezholder.GetComponent<RectTransform>();
        posFinal = finalholder.GetComponent<RectTransform>();
        panelPesca = pescaHolder.GetComponent<RectTransform>();
        posInicio = holder.transform.position;
        pescadin.gameObject.SetActive(true);
        */
        pez = GameObject.Find("ArcoPececin").GetComponent<RectTransform>();
        posFinal = GameObject.Find("ArcoFalloPesca").GetComponent<RectTransform>();
        panelPesca = GameObject.Find("ArcoMiniPesca").GetComponent<RectTransform>();
        //holder = GameObject.Find("HolderPecesin").GetComponent<RectTransform>();

        posInicio = pez.transform.position;
        GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(true);
        if (OrbeArcoB.pescarConArco)
        {
            /*
            pescadin.gameObject.SetActive(false);
            orbe.gameObject.SetActive(true);
            */
            GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
            GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(true);

            vel = 500;
        }
        StartCoroutine(MoverPez());
    }
    void Start()
    {
        contador = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
        sonidosPesca.volume = GameMaster.instanciaCompartida.volumenEfectos;
        //OrbeArcoB = GameObject.Find("OrbeArco").GetComponent<OrbeArco>();
    }
    private void OnDisable()
    {
        //pez.transform.position = posInicio;
        pez.transform.position = holder.transform.position;
        StopCoroutine(MoverPez());
    }

    private IEnumerator MoverPez()
    {
        while (true)
        {
            if(!OrbeArcoB.pescarConArco)
                vel = (Random.Range(3, 10) * 100);

            while (Vector2.Distance(pez.transform.position, posFinal.transform.position) > 0)
            {
                pez.transform.position = Vector2.MoveTowards(pez.transform.position, posFinal.transform.position, Time.deltaTime * vel);
                yield return new WaitForSecondsRealtime(0.02f);
            }
            yield return new WaitForSecondsRealtime(0.02f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FalloPesca")
        {
            sonidosPesca.clip = fallo;
            sonidosPesca.Play();
            GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
            vel = 0;
            pez.transform.position = holder.transform.position;
            //panelPesca.gameObject.SetActive(false);
            StartCoroutine(Delay());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExitoPesca")
        {
            if (!OrbeArcoB.pescarConArco)
            {
                if (Input.GetButtonDown("e"))
                {
                    sonidosPesca.clip = exito;
                    sonidosPesca.Play();

                    GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                    vel = 0;
                    pez.transform.position = holder.transform.position;
                    current_selected_obj = pescado.transform.gameObject;
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    contadorPecesA++;
                    contador.contadorA = contadorPecesA;
                    StartCoroutine(Delay());
                }
            }
            if (OrbeArcoB.pescarConArco)
            {
                if (Input.GetButtonDown("e"))
                {
                    sonidosPesca.clip = exito;
                    sonidosPesca.Play();

                    GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(false);
                    vel = 0;
                    pez.transform.position = holder.transform.position;
                    current_selected_obj = orbeF.transform.gameObject;
                    
                    GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                    OrbeArcoB.pescarConArco = false;
                    StartCoroutine(Delay());
                }
            }
            
        }

        else if (collision.gameObject.tag == "AguaPesca")
        {
            if (Input.GetButtonDown("e"))
            {
                sonidosPesca.clip = fallo;
                sonidosPesca.Play();
                GameObject.Find("ArcoPececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                vel = 0;
                pez.transform.position = holder.transform.position;
                StartCoroutine(Delay());
                //panelPesca.gameObject.SetActive(false);
            }
        }
    }

    IEnumerator Delay()
    {
       
        yield return new WaitForSecondsRealtime(1.5f);
        panelPesca.gameObject.SetActive(false);
    }
}
