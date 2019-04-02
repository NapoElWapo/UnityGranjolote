using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaAjolote : MonoBehaviour
{
    public string Movimiento, Asustado;

    public static bool harto, movimiento, asustado;

    public float velocidad = 5f;
    public float cambioDireccion = 1f;
    public float maxCambio = 30f;

    Animator ajoloteAnimator;

    CharacterController controller;
    float direccion;
    Vector3 rotacion;

    // Start is called before the first frame update
    void Start()
    {
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
            ajoloteAnimator.SetBool(Movimiento,true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);
            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidad);
        }
        
    }

    IEnumerator NuevaDireccion()
    {
        while (true)
        {
            NuevaDireccionRutina();
            yield return new WaitForSeconds(cambioDireccion);
        }
    }

    void NuevaDireccionRutina()
    {
        float piso = transform.eulerAngles.y - maxCambio;
        float techo = transform.eulerAngles.y + maxCambio;
        direccion = Random.Range(piso, techo);
        rotacion = new Vector3(0, direccion, 0);
    }
}
