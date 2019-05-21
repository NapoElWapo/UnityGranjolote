using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteDesecho : MonoBehaviour
{

    public RectTransform boton;
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<RectTransform>();
        StartCoroutine(GenerarDesecho());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerarDesecho()
    {
        yield return new WaitForSeconds(4);
        boton.gameObject.SetActive(true);
        StopCoroutine(GenerarDesecho());
    }

    public void recogerDesecho()
    {
        boton.gameObject.SetActive(false);
        StartCoroutine(GenerarDesecho());
    }
}
