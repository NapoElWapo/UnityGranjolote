using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaAjolote : MonoBehaviour
{
    public string Movimiento, Asustado;

    public bool harto, movimiento, asustado, vagar;

    public float velocidad = 2f;
    public float velocidadAsustado = 7f;
    public float cambioDireccion = 0.5f;
    public float maxCambio = 180f;
    public float tiempoHarto = 6f;

    Animator ajoloteAnimator;
    CharacterController controller;
    SphereCollider sphereCollider;

    float direccion;
    Vector3 rotacion;
    private Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        harto = false;
        movimiento = false;
        asustado = false;
        vagar = false;

        ajoloteAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        sphereCollider = gameObject.GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        
        direccion = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, direccion, 0);  
    }

    // Update is called once per frame
    void Update()
    {
        if(!vagar)
        {
            StartCoroutine(Vagar());
        }

        if (!harto&&!movimiento)
        {
            StopCoroutine(NuevaDireccion());
            ajoloteAnimator.SetBool(Movimiento, false);
        }
        if (!harto&&movimiento)
        {
            StartCoroutine(NuevaDireccion());
            ajoloteAnimator.SetBool(Movimiento, true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);
            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidad);
            //transform.eulerAngles.z = 0;
        }
        else if(harto)
        {
            ajoloteAnimator.SetBool(Asustado, true);
            ajoloteAnimator.SetBool(Movimiento, true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);
            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidad);
            StartCoroutine(Delay());
        }
    }
    
    IEnumerator Vagar()
    {
        vagar = true;
        int esperaCaminar = Random.Range(2, 5);
        int tiempoCaminar = Random.Range(2, 6);
        movimiento = false;
        yield return new WaitForSeconds(esperaCaminar);
        movimiento = true;
        yield return new WaitForSeconds(tiempoCaminar);
        vagar = false;
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

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(tiempoHarto);
        Destroy(this.gameObject);
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
        if(other.tag=="Player")
        {
            ajoloteAnimator.SetBool(Movimiento, true);
            ajoloteAnimator.SetBool(Asustado, true);
            this.velocidad = velocidadAsustado;
            this.harto = true;
            ajoloteAnimator.Play("Armature|correr");
            //Debug.Log("Triggerea");
        }
        if(other.tag=="LimiteAjolote")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
    }
}
