using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public bool hablando;

    public float speed;//
    private float waitTime;//
    public float startWaitTime;//

    public Transform[] moveSpots;//
    private int randomSpot;//

    void Start()
    {
        waitTime = startWaitTime;//
        randomSpot = Random.Range(0, moveSpots.Length);//
        hablando = false;
    }

    public GameObject continueBotton;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);//

        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)//
        {
            if(waitTime <=0)//
            {
                randomSpot = Random.Range(0, moveSpots.Length);//
                waitTime = startWaitTime;//
            }
            else
            {
                waitTime -= Time.deltaTime;//
            }
        }
        if(textDisplay.text == sentences[index])
        {
            continueBotton.SetActive(true);
        }          
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (hablando == false)
            {
                if (Input.GetButtonDown("e"))
                {
                    hablando = true;
                    StartCoroutine (Type());
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
        if (index < sentences.Length -1)
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
        }
    }
}
