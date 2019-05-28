using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinijuegoPescar : MonoBehaviour
{
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
            panelPesca.gameObject.SetActive(false);
            contadorConsecutivoPeces = 0;
            contador.contadorConsecutivo = contadorConsecutivoPeces;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExitoPesca")
        {
            if (Input.GetButtonDown("e"))
            {
                
                GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                vel = 0;
                contadorConsecutivoPeces++;
                contador.contadorConsecutivo = contadorConsecutivoPeces;
                StartCoroutine(DelayCR());
                //Delay();
            }
        }

        else if (collision.gameObject.tag == "AguaPesca")
        {
            if (Input.GetButtonDown("e"))
            {
                panelPesca.gameObject.SetActive(false);
                contadorConsecutivoPeces=0;
                contador.contadorConsecutivo = contadorConsecutivoPeces;
            }
        }
    }
    
    IEnumerator DelayCR()
    {
        //Delay();
        yield return new WaitForSecondsRealtime(1.5f);
        current_selected_obj = pescado.transform.gameObject;
        GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
        contadorPecesL++;
        contador.contadorL = contadorPecesL;
        panelPesca.gameObject.SetActive(false);
    }
    
    /*
    void Delay()
    {
        esperaTimer = true;
        if(esperaTimer)
        {
            timer += Time.deltaTime;
            if (timer >= 1.5f)
            {
                esperaTimer = false;
                current_selected_obj = pescado.transform.gameObject;
                GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
                contadorPecesL++;
                contador.contadorL = contadorPecesL;
                
                panelPesca.gameObject.SetActive(false);
            }
        }
    }
    */
}
