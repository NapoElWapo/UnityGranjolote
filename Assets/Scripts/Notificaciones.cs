using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificaciones : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject popUpMisiones,popUpAlcalde,popUpMC,popUpLC,popUpT;
    LogrosYMisiones conexLM;
    AlcaldeMisiones conexAM;

    void Start()
    {
        StartCoroutine(MostrarPM());
        conexAM = GameObject.Find("AlcaldeMisiones").GetComponent<AlcaldeMisiones>();
        conexLM = GameObject.Find("InventarioUI").GetComponent<LogrosYMisiones>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void popM()
    {
        StartCoroutine(MostrarMC());
    }

    public void popL()
    {
        StartCoroutine(MostrarLC());
    }

    public void popO()
    {
        StartCoroutine(MostrarT());
    }

    public void popA()
    {
        StartCoroutine(MostrarMA());
    }

    public void popD()
    {
        StartCoroutine(MostrarPM());
    }

    IEnumerator MostrarPM()
    {
        Animator animator = popUpMisiones.GetComponent<Animator>();
        bool mostrar = animator.GetBool("Mostrar");
        animator.SetBool("Mostrar", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("Mostrar", false);
    }

    IEnumerator MostrarMA()
    {
        Animator animator = popUpAlcalde.GetComponent<Animator>();
        bool mostrar = animator.GetBool("Mostrar");
        animator.SetBool("Mostrar", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("Mostrar", false);
    }

    IEnumerator MostrarMC()
    {
        Animator animator = popUpMC.GetComponent<Animator>();
        bool mostrar = animator.GetBool("Mostrar");
        animator.SetBool("Mostrar", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("Mostrar", false);
    }

    IEnumerator MostrarLC()
    {
        Animator animator = popUpLC.GetComponent<Animator>();
        bool mostrar = animator.GetBool("Mostrar");
        animator.SetBool("Mostrar", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("Mostrar", false);
    }

    IEnumerator MostrarT()
    {
        Animator animator = popUpT.GetComponent<Animator>();
        bool mostrar = animator.GetBool("Mostrar");
        animator.SetBool("Mostrar", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("Mostrar", false);
    }
}
