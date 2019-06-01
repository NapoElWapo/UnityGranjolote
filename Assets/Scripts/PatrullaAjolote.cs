using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaAjolote : MonoBehaviour
{
    public string Movimiento, Asustado;

    public bool harto, movimiento, asustado, vagar, awaEspanta, lumbreEspanta, CrDireccion, llamarCrDireccion;

    public float velocidad = 2f;
    public float velocidadAwado;
    public float velocidadAlumbrado;
    public float velocidadAsustado = 7f;
    public float velocidadAwadoAsustado;
    public float velocidadAlumbradoAsustado;
    public float cambioDireccion = 0.5f;
    public float maxCambio = 180f;
    public float tiempoHarto = 6f;
    public float tiempoHartoAwado;
    public float tiempoHartoAlumbrado;
    public int contador;
    Animator ajoloteAnimator;
    CharacterController controller;
    SphereCollider sphereCollider;
    public SpawnAjolote spawn;
    public string buscarSpawn;


    float direccion;
    Vector3 rotacion;

    WaitForSeconds[] seconds;

    void Start()
    {
        seconds = new WaitForSeconds[]
        {
            new WaitForSeconds(Random.Range(2, 6)),
            new WaitForSeconds(Random.Range(2, 6)),
            new WaitForSeconds(Random.Range(2, 6)),
            new WaitForSeconds(Random.Range(2, 6)),
            new WaitForSeconds(Random.Range(2, 6)),
        };
        harto = false;
        movimiento = false;
        asustado = false;
        vagar = false;

        ajoloteAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        direccion = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, direccion, 0);
        spawn = GameObject.Find("SpawnerA" + buscarSpawn).GetComponent<SpawnAjolote>();
    }

    // * Vagar() no debe llamarse a cada rato en update
    // * NuevaDireccion() no debe llamarse en update
    // * NO LLAMAR CORUTINAS EN UPDATE


    void Update()
    {
        if (!vagar)
        {
            StartCoroutine(Vagar());
        }
        if (!harto && !movimiento)
        {
            Debug.LogWarning("Se esta deteniendo nueva direccion en update");
            StopCoroutine(NuevaDireccion());
            ajoloteAnimator.SetBool(Movimiento, false);
        }
        if (!harto && movimiento)
        {
            //Debug.LogWarning("Se esta llamando nueva direccion");
            if(llamarCrDireccion)
                StartCoroutine(NuevaDireccion());

            ajoloteAnimator.SetBool(Movimiento, true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);

            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidad);
        }
        else if (harto)
        {
            ajoloteAnimator.SetBool(Asustado, true);
            ajoloteAnimator.SetBool(Movimiento, true);
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, rotacion, Time.deltaTime * cambioDireccion);

            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(adelante * velocidadAsustado);
            StartCoroutine(Delay());
        }

    }

    void LateUpdate()
    {
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);
    }

    IEnumerator Vagar()
    {
        Debug.LogWarning("Se esta llamando vagar");
        vagar = true;
        int esperaCaminar = Random.Range(0, 5);
        int tiempoCaminar = Random.Range(0, 5);
        movimiento = false;
        CrDireccion = false;
        yield return seconds[esperaCaminar];
        movimiento = true;
        llamarCrDireccion = true;
        CrDireccion = true;
        yield return seconds[tiempoCaminar];
        vagar = false;
        Debug.LogWarning("Se esta deteniendo vagar");
    }

    IEnumerator NuevaDireccion()
    {
        llamarCrDireccion = false;
        Debug.LogWarning("Se esta llamando nueva direccion");
        while (CrDireccion)
        {
            NuevaDireccionRutina();
            yield return new WaitForSeconds(cambioDireccion);
            controller.transform.eulerAngles.z.Equals(0);
            controller.transform.eulerAngles.x.Equals(0);
        }
        Debug.LogWarning("Se esta deteniendo nueva direccion");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(tiempoHarto);
        spawn.cantidadActual--;
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
        /*
        if(other.tag=="Player")
        {
            ajoloteAnimator.SetBool(Movimiento, true);
            ajoloteAnimator.SetBool(Asustado, true);
            this.harto = true;
            ajoloteAnimator.Play("Armature|correr");
            //Debug.Log("Triggerea");
        }

        if(other.tag == "Agua"|| other.tag == "Agua2")
        {
            velocidad = velocidadAwado;
            velocidadAsustado = velocidadAwadoAsustado;
            tiempoHarto = tiempoHartoAwado;
            if (awaEspanta)
                harto = true;
        }

        if (other.tag == "Fuego" || other.tag == "Fuego2")
        {
            velocidad = velocidadAlumbrado;
            velocidadAsustado = velocidadAlumbradoAsustado;
            tiempoHarto = tiempoHartoAlumbrado;
            if (lumbreEspanta)
                harto = true;
        }
        */
        if (other.tag == "LimiteAjolote")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
            /*
            contador = 1;
            if(contador==1)
            {
                transform.RotateAround(transform.position, transform.up, 180f);
                contador = 0;
            }
            */

        }

    }

    public void TriggerJugador()
    {
        ajoloteAnimator.SetBool(Movimiento, true);
        ajoloteAnimator.SetBool(Asustado, true);
        this.harto = true;
        ajoloteAnimator.Play("Armature|correr");
    }

    public void TriggerAgua()
    {
        velocidad = velocidadAwado;
        velocidadAsustado = velocidadAwadoAsustado;
        tiempoHarto = tiempoHartoAwado;
        if (awaEspanta)
            harto = true;
    }

    public void TriggerFuego()
    {
        velocidad = velocidadAlumbrado;
        velocidadAsustado = velocidadAlumbradoAsustado;
        tiempoHarto = tiempoHartoAlumbrado;
        if (lumbreEspanta)
            harto = true;
    }
}
