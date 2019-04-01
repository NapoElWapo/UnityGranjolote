using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaAjolote : MonoBehaviour
{
    public string idleState, asustadoState;
    public bool movimiento, asustado;

    public static bool harto = false;

    public float velocidad = 5f;
    public float cambioDireccion = 1f;
    public float maxGiro = 90f;

    Animator ajoloteAnimator;

    CharacterController controller;
    float direccion;
    Vector3 rotacion;

    // Start is called before the first frame update
    void Start()
    {
        movimiento = false;
        ajoloteAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();

        direccion = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, direccion, 0);

        StartCoroutine(NuevaDireccion());
    }

    // Update is called once per frame
    void Update()
    {
        if (!harto)
        {
            movimiento = true;
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);
            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            //Vector3 adelante = transform.forward;
            controller.SimpleMove(adelante*velocidad);
        }
        else
        {
            //asustado = true;
        }
    }

    IEnumerator NuevaDireccion()
    {
        while (true)
        {
            NuevaRutinaDireccion();
            yield return new WaitForSeconds(cambioDireccion);
        }
    }

    void NuevaRutinaDireccion()
    {
        float suelo = transform.eulerAngles.y - maxGiro;
        float techo = transform.eulerAngles.y + maxGiro;
        direccion = Random.Range(suelo, techo);
        rotacion = new Vector3(0, direccion, 0);
    }

    
}
