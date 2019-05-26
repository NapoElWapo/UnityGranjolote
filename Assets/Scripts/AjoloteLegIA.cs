using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteLegIA : MonoBehaviour
{
    public string Movimiento, Asustado;

    public bool movimiento, asustado;

    public float velocidad = 2f;
    public float velocidadAsustado = 7f;
    public float cambioDireccion = 0.5f;
    public float maxCambio = 180f;
    public int contador;
    Animator ajoloteAnimator;
    CharacterController controller;
    SphereCollider sphereCollider;

    float direccion;
    Vector3 rotacion;

    void Start()
    {
        movimiento = true;
        asustado = true;

        ajoloteAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        direccion = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, direccion, 0);
    }

    void Update()
    {
        if (!movimiento)
        {
            StopCoroutine(NuevaDireccion());
            ajoloteAnimator.SetBool(Movimiento, false);
        }
        if (movimiento)
        {
            StartCoroutine(NuevaDireccion());
            ajoloteAnimator.SetBool(Movimiento, true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);

            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidad);
        }
    }

    void LateUpdate()
    {
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);
    }

    IEnumerator NuevaDireccion()
    {
        while (true)
        {
            NuevaDireccionRutina();
            yield return new WaitForSeconds(cambioDireccion);
            controller.transform.eulerAngles.z.Equals(0);
            controller.transform.eulerAngles.x.Equals(0);
        }
    }

    void NuevaDireccionRutina()
    {
        float piso = transform.eulerAngles.y - maxCambio;
        float techo = transform.eulerAngles.y + maxCambio;
        direccion = Random.Range(piso, techo);
        rotacion = new Vector3(0, direccion, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ajoloteAnimator.SetBool(Movimiento, true);
            ajoloteAnimator.SetBool(Asustado, true);
            ajoloteAnimator.Play("Armature|correr");
            //Debug.Log("Triggerea");
        }
        else if (other.tag == "LimiteAjolote")
        {
            contador = 1;
            if (contador == 1)
            {
                transform.RotateAround(transform.position, transform.up, 180f);
                contador = 0;
            }
        }
    }
}
