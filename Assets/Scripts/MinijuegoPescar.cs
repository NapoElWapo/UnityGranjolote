using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinijuegoPescar : MonoBehaviour
{
    public RectTransform pez, posFinal, panelPesca;

    private Vector2 posInicio;
    private float vel = 100f;

    private void OnEnable()
    {
        pez = GameObject.Find("Pececin").GetComponent<RectTransform>();
        posFinal = GameObject.Find("FalloPesca").GetComponent<RectTransform>();
        panelPesca = GameObject.Find("MiniPesca").GetComponent<RectTransform>();
        posInicio = pez.transform.position;
        StartCoroutine(MoverPez());
    }

    private void OnDisable()
    {
        pez.transform.position = posInicio;
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
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExitoPesca")
        {
            if (Input.GetKeyDown("e"))
            {
                GameObject.Find("Pececin").GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false);
                vel = 0;
                StartCoroutine(Delay());
            }
        }

        else if (collision.gameObject.tag == "AguaPesca")
        {
            if (Input.GetKeyDown("e"))
            {
                panelPesca.gameObject.SetActive(false);
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        panelPesca.gameObject.SetActive(false);
    }
}