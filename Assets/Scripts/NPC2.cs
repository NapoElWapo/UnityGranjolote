using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC2 : MonoBehaviour
{
    public static NPC2 instancia;
    public TextMeshProUGUI textDisplay;
    public float typingSpeed;

    public string[] sentences;

    public string[] Calor;
    public bool calor;

    public string[] Frio;
    public bool frio;

    private int index;
    private bool hablando;    

    [SerializeField]
    bool patrolWaiting;

    [SerializeField]
    float totalWaitTime = 3f;

    [SerializeField]
    float switchProbability = 0.2f;

    [SerializeField]
    List<Waypoint> patrolPoints;

    NavMeshAgent agent;
    int currentPatrolIndex;
    bool traveling;
    bool waiting;
    bool patrolForward;
    float waitTimer;

    public GameObject continueBotton;
    public GameObject continueBottonCalor;
    public GameObject continueBottonFrio;
    public GameObject PlayerUI;

    Animator npc2Animator;

    void Start()
    {
        instancia = this;
        agent = this.GetComponent<NavMeshAgent>();
        npc2Animator = GetComponent<Animator>();

        if (agent == null)
        {
            Debug.LogError("El componente nav mesh component no esta agregado al " + gameObject.name);
        }
        else
        {
            if (patrolPoints != null && patrolPoints.Count >= 2)
            {
                currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("No hay puntos suficientes");
            }
        }
        hablando = false;
    }

    public void Update()
    {
        if (traveling && agent.remainingDistance <= 1.0f)
         {
             traveling = false;
             npc2Animator.Play("Armature|Iddle");
             if (patrolWaiting)
             {
                 waiting = true;
                 waitTimer = 0f;
             }
             else
             {
                npc2Animator.Play("Armature|Caminar");
                 ChangePatrolPoint();
                 SetDestination();
             }
         }
         if (waiting)
         {
             waitTimer += Time.deltaTime;
             if (waitTimer >= totalWaitTime)
             {
                 waiting = false;
                 ChangePatrolPoint();
                 SetDestination();
             }
         }
        if (textDisplay.text == sentences[index])
        {
            continueBotton.SetActive(true);
        }
        if (textDisplay.text == Calor[index])
        {
            continueBottonCalor.SetActive(true);
        }
        if (textDisplay.text == Frio[index])
        {
            continueBottonFrio.SetActive(true);
        }
        if (hablando == true)
        {
            PlayerUI.SetActive(false);
        }
        if (GameMaster.instanciaCompartida.hora >= 19)
        {
            totalWaitTime = 60f;
            currentPatrolIndex = 0;
            Vector3 targetVector = patrolPoints[currentPatrolIndex].transform.position;
            agent.SetDestination(targetVector);
            traveling = true;
            if (GameMaster.instanciaCompartida.hora >= 20)
            {
                //this.SetActive(false);
            }
        }
        else if (GameMaster.instanciaCompartida.hora >= 8)
        {
            totalWaitTime = 10f;
            //this.SetActive(true);
        }
    }

    private void SetDestination()
    {
        if (patrolPoints != null)
        {
            Vector3 targetVector = patrolPoints[currentPatrolIndex].transform.position;
            agent.SetDestination(targetVector);
            traveling = true;
        }
    }

    private void ChangePatrolPoint()
    {
        if (UnityEngine.Random.Range(0f, 1f) <= switchProbability)
        {
            patrolForward = !patrolForward;
        }
        if (patrolForward)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Count;
        }
        else
        {
            if (--currentPatrolIndex < 0)
            {
                currentPatrolIndex = patrolPoints.Count - 1;
            }
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
                    GetComponent<NavMeshAgent>().speed = 0f;
                    if (calor == false && frio == false)
                    {
                        hablando = true;
                        StartCoroutine(Type());
                    }
                    else if (calor == true)
                    {
                        hablando = true;
                        StartCoroutine(TypeCalor());
                    }
                    else if (frio == true)
                    {
                        hablando = true;
                        StartCoroutine(TypeFrio());
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

    IEnumerator TypeCalor()
    {
        foreach (char letter in Calor[index].ToCharArray())
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

    IEnumerator TypeFrio()
    {
        foreach (char letter in Frio[index].ToCharArray())
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
            GetComponent<NavMeshAgent>().speed = 5f;
            PlayerUI.SetActive(true);
        }
    }

    public void NextSentenceCalor()
    {
        continueBottonCalor.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeCalor());
        }
        else
        {
            textDisplay.text = "";
            continueBottonCalor.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
            index = 0;
            hablando = false;
            GetComponent<NavMeshAgent>().speed = 5f;
            PlayerUI.SetActive(true);
            calor = false;
        }
    }

    public void NextSentenceFrio()
    {
        continueBottonFrio.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeFrio());
        }
        else
        {
            textDisplay.text = "";
            continueBottonFrio.SetActive(false);
            var mousestate = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.lockCursor = true;
            var mouseLook = GameObject.Find("FPSController").GetComponent<FirstPersonController>().MouseLook;
            mouseLook.XSensitivity = 2F;
            mouseLook.YSensitivity = 2F;
            Time.timeScale = 1f;
            index = 0;
            hablando = false;
            GetComponent<NavMeshAgent>().speed = 5f;
            PlayerUI.SetActive(true);
            frio = false;
        }
    }
}
