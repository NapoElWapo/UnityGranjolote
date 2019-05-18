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

        if (this.tag == "Bosque" && other.tag == "Player")
        {
            Debug.Log(imagenMapa.transform.position);
            imagenMapa.position = new Vector2(490f, 275f);
            Debug.Log("Cambio de zona");
            Debug.Log(imagenMapa.transform.position);
        }
    }
}
