using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class AlcaldeDoctor : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float typingSpeed;
    public string[] sentences;
    private int index;
    private bool hablando;
    MenuInventario conexMI;
    public bool AEnlatado;
    public string[] CurarAEnlatado;
    public GameObject current_selected_obj, ASA;

    public GameObject continueBotton;
    public GameObject continueBottoncurar;
    public GameObject PlayerUI;

    void Start()
    {
        hablando = false;
        conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();
    }

    public void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueBotton.SetActive(true);
        }
        if (hablando == true)
        {
            PlayerUI.SetActive(false);
        }
        if (textDisplay.text == CurarAEnlatado[index])
        {
            continueBottoncurar.SetActive(true);
        }
        if (hablando == true)
        {
            PlayerUI.SetActive(false);
        }
        foreach (var iterador in conexMI.herramientas)
        {
            if (iterador.RealItemName == "AjoloteEnlatado")
            {
                AEnlatado = true;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("e"))
            {               
                if (hablando == false && AEnlatado == false)
                {
                    hablando = true;
                    StartCoroutine(Type());
                }
                else if (hablando==false&&AEnlatado)
                {
                    hablando = true;
                    StartCoroutine(TypeCurar());
                }
            }   
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 1f;
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    IEnumerator TypeCurar()
    {
        foreach (char letter in CurarAEnlatado[index].ToCharArray())
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = false;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 0.0F;
            mouseLook.YSensitivity = 0.0F;
            Time.timeScale = 1f;
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        current_selected_obj = ASA.transform.gameObject;
        GameMaster.instanciaCompartida.inventario.AddItem(current_selected_obj?.GetComponent<ItemInventario>());
    }

    public void NextSentence()
    {
        continueBotton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueBotton.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
            index = 0;
            hablando = false;
            PlayerUI.SetActive(true);
        }
    }

    public void NextSentenceA()
    {
        continueBottoncurar.SetActive(false);
        if (index < CurarAEnlatado.Length - 1 )
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeCurar());
        }
        else
        {
            textDisplay.text = "";
            continueBottoncurar.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
            index = 0;
            hablando = false;
            PlayerUI.SetActive(true);
        }
    }
}
