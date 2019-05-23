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

    public GameObject continueBotton;
    public GameObject PlayerUI;

    void Start()
    {
        hablando = false;
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
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hablando == false)
            {
                if (Input.GetButtonDown("e"))
                {
                    hablando = true;
                    StartCoroutine(Type());
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
}
