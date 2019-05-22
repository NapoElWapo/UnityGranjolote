using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteIA : MonoBehaviour
{
    public float velocidad = 3f;
    public float rotacionVelocidad = 100f;

    private bool vagando = false;
    private bool rotaIzq = false;
    private bool rotaDer = false;
    private bool caminando = false;

    void Update()
    {
        if(vagando == false)
        {
            StartCoroutine(Vagar());
        }
        if(rotaDer == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotacionVelocidad);
        }
        if (rotaIzq == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotacionVelocidad);
        }
        if(caminando == true)
        {
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
    }

    IEnumerator Vagar()
    {
        int tiempoRotacion = Random.Range(1, 3);
        int esperaRotacion = Random.Range(1, 4);
        int rotacionIoD = Random.Range(1, 2);
        int esperaCaminar = Random.Range(1, 4);
        int tiempoCaminar = Random.Range(1, 5);

        vagando = true;

        yield return new WaitForSeconds(esperaCaminar);
        caminando = true;
        yield return new WaitForSeconds(tiempoCaminar);
        caminando = false;
        yield return new WaitForSeconds(esperaRotacion);
        if (rotacionIoD == 1)
        {
            rotaIzq = true;
            yield return new WaitForSeconds(esperaRotacion);
            rotaIzq = false;
        }
        if (rotacionIoD == 2)
        {
            rotaDer = true;
            yield return new WaitForSeconds(esperaRotacion);
            rotaDer = false;
        }
        vagando = false;
    }
}
