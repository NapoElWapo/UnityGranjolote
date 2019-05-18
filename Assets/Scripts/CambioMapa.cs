using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class CambioMapa : MonoBehaviour
{
    public RectTransform imagenMapa;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();
        imagenMapa = GameObject.Find("JugadorMapa").GetComponent<RectTransform>();
        boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "Pueblo" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(-257f, 43f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Planicie" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(-40f, 43f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Bosque" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(-28f, -50f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Cueva" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(136f, -50f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Rocas" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(139f, 43f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Volcan" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(293f, 43f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Nevada" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(364f, 68f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }

        if (this.tag == "Nube" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.localPosition);
            imagenMapa.localPosition = new Vector2(329f, -62f);
            Debug.Log("Cambio de zona a " + this.tag);
            Debug.Log(imagenMapa.localPosition);
        }
    }
}