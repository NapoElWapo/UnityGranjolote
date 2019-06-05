using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinijuegoPescar : MonoBehaviour
{
    public AudioSource sonidosPesca;
    public AudioClip fallo, exito;

    public RectTransform pez, posFinal, panelPesca,holder,pescaHolder,finalholder,pezholder;
    public GameObject pescado, current_selected_obj;
    private Vector2 posInicio;
    private float vel;
    public int contadorPecesL=0;
    public int contadorConsecutivoPeces = 0;
    public float timer = 0f;
    bool esperaTimer;
    LogrosYMisiones contador;
    private void OnEnable()
    {
        /*
        pez = pezholder.GetComponent<RectTransform>();
        posFinal = finalholder.GetComponent<RectTransform>();
        panelPesca = pescaHolder.GetComponent<RectTransform>();
        posInicio = holder.transform.position;
        */
        
        pez = GameObject.Find("Pececin").GetComponent<RectTransform>();
        posFinal = GameObject.Find("FalloPesca").GetComponent<RectTransform>();
        panelPesca = GameObject.Find("MiniPesca").GetComponent<RectTransform>();
        //holder = GameObject.Find("HolderPecesin").GetComponent<RectTransform>();
        posInicio = pez.transform.position;
        GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(true);
        StartCoroutine(MoverPez());
    }
    void Start()
    {
        //sonidosPesca.volume = GameMaster.instanciaCompartida.volumenEfectos;
        sonidosPesca.volume = GameMaster.instanciaCompartida.volumenEfectos;
        contador = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
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
            GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
            vel = 0;
            pez.transform.position = holder.transform.position;
            //panelPesca.gameObject.SetActive(false);
            contadorConsecutivoPeces = 0;
            contador.contadorConsecutivo = contadorConsecutivoPeces;
            StartCoroutine(DelayCR());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExitoPesca")
        {
            if (Input.GetButtonDown("e"))
            {
                sonidosPesca.clip = exito;
                sonidosPesca.Play();
                GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                vel = 0;
                pez.transform.position = holder.transform.position;
                contadorConsecutivoPeces++;
                contador.contadorConsecutivo = contadorConsecutivoPeces;
                current_selected_obj = pescado.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                contadorPecesL++;
                contador.contadorL = contadorPecesL;
                StartCoroutine(DelayCR());
                //Delay();
            }
        }

        else if (collision.gameObject.tag == "AguaPesca")
        {
            if (Input.GetButtonDown("e"))
            {
                sonidosPesca.clip = fallo;
                sonidosPesca.Play();
                GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                vel = 0;
                pez.transform.position = holder.transform.position;
                //panelPesca.gameObject.SetActive(false);
                contadorConsecutivoPeces =0;
                contador.contadorConsecutivo = contadorConsecutivoPeces;
                StartCoroutine(DelayCR());
            }
        }
    }
    
    IEnumerator DelayCR()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        panelPesca.gameObject.SetActive(false);
    }
    
}
