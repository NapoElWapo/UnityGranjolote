using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinijuegoPescar : MonoBehaviour
{
    public RectTransform pez;
    public RectTransform posFinal;

    public BoxCollider2D colliderPez, colliderFallo, colliderExito;

    private Vector2 posInicio;
    private float vel = 300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(MoverPez());
        colliderPez = GameObject.Find("Pececin").GetComponent<BoxCollider2D>();
        colliderExito = GameObject.Find("ZonaExito").GetComponent<BoxCollider2D>();
        colliderFallo = GameObject.Find("FalloPesca").GetComponent<BoxCollider2D>();
        //colliderPez = GetComponent<BoxCollider2D>();
        //colliderPez.isTrigger = true;
        //colliderExito.isTrigger = false;
        //colliderFallo.isTrigger = false;

        posInicio = pez.transform.position;
        Debug.Log("Pesca on");
    }

    private void OnDisable()
    {
        pez.transform.position = posInicio;
        StopCoroutine(MoverPez());
        pez.transform.position = posInicio;
    }

    private IEnumerator MoverPez()
    {
        while (true)
        {
            //vel = (Random.Range(3, 10) * 100);
            while (Vector2.Distance(pez.transform.position, posFinal.transform.position) > 0)
            {
                pez.transform.position = Vector2.MoveTowards(pez.transform.position, posFinal.transform.position, Time.deltaTime * vel);
                yield return new WaitForSeconds(0.02f);
            }
            yield return new WaitForSeconds(0.02f);
        } 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisiono algo");

        if (collision.gameObject == colliderExito)
        {
            Debug.Log("Pez etzitoso");
        }

        if (collision.gameObject == colliderFallo)
        {
            pez.transform.position = posInicio;
            Debug.Log("Pez colisiona");
        }

        else
        {

        }
    }
}