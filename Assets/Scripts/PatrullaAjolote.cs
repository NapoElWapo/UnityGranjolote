using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaAjolote : MonoBehaviour
{
    public string Movimiento, Asustado;

    public bool harto, movimiento, asustado;

    public float velocidad = 2f;
    public float velocidadAsustado = 7f;
    public float cambioDireccion = 0.5f;
    public float maxCambio = 180f;
    public float tiempoHarto = 6f;

    Animator ajoloteAnimator;

    CharacterController controller;
    float direccion;
    Vector3 rotacion;

    // Start is called before the first frame update
    void Start()
    {
        ajoloteAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        SphereCollider sphereCollider = gameObject.GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        

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

    IEnumerator NuevaDireccion()
    {
        while (true)
        {
            NuevaDireccionRutina();
            yield return new WaitForSeconds(cambioDireccion);
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
            this.velocidad = velocidadAsustado;
            this.harto = true;
            //ajoloteAnimator.Play("Armature|correr");
            Debug.Log("Triggerea");
        }
    }


}
