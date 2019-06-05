using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class Alcalde : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float typingSpeed;
    public string[] sentences;
    public string[] sentencesMision;
    public bool mision;
    private int index;
    private bool hablando;

    AlcaldeMisiones mostrar;

    public GameObject continueBotton;
    public GameObject continueBottonMision;
    public GameObject PlayerUI;

    void Start()
    {
        hablando = false;
        mostrar = GameObject.Find("AlcaldeMisiones").GetComponent<AlcaldeMisiones>();
    }

    public void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueBotton.SetActive(true);
        }
        if (textDisplay.text == sentencesMision[index])
        {
            continueBottonMision.SetActive(true);
        }
        if (hablando == true)
        {
            PlayerUI.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hablando == false)
            {
                if (Input.GetButtonDown("e"))
                {
                    if (mision == false)
                    {
                        hablando = true;
                        StartCoroutine(Type());
                    }
                    else if (mision == true)
                    {
                        hablando = true;
                        StartCoroutine(TypeMision());
                    }
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

    IEnumerator TypeMision()
    {
        foreach (char letter in sentencesMision[index].ToCharArray())
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

    public void NextSentenceMision()
    {
        continueBottonMision.SetActive(false);
        if (index < sentencesMision.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeMision());
        }
        else
        {
            textDisplay.text = "";
            continueBottonMision.SetActive(false);
            continueBotton.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
            index = 0;
            hablando = false;
            PlayerUI.SetActive(true);
            mostrar.ToggleAMisiones();
        }
    }
}
