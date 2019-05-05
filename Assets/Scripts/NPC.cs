using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private bool hablando;

    //public float speed;//
    //private float waitTime;//
    //public float startWaitTime;//

    /*public Transform pos1;//
    public Transform pos2;//
    public Transform pos3;//
    public Transform pos4;//*/

    [SerializeField]
    bool patrolWaiting;

    [SerializeField]
    float totalWaitTime = 3f;

    [SerializeField]
    float switchProbability = 0.2f;

    [SerializeField]
    List<Waypoint> patrolPoints;

    NavMeshAgent agent;//
    int currentPatrolIndex;
    bool traveling;
    bool waiting;
    bool patrolForward;
    float waitTimer;

    
    //private int randomSpot;//
    public GameObject continueBotton;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();////

        if(agent == null)
        {
            Debug.LogError("El componente nav mesh component no esta agregado al " + gameObject.name);
        }
        else
        {
            if(patrolPoints != null && patrolPoints.Count >= 2)
            {
                currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("No hay puntos suficientes");
            }
        }
        //waitTime = startWaitTime;//
        //randomSpot = Random.Range(0, moveSpots.Length);//
        hablando = false;
    }

    public void Update()
    {
        if (traveling && agent.remainingDistance <= 1.0f)
        {
            traveling = false;

            if (patrolWaiting)
            {
                waiting = true;
                waitTimer = 0f;
            }
            else
            {
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
    }

    private void SetDestination()
    {
        if(patrolPoints != null)
        {
            Vector3 targetVector = patrolPoints[currentPatrolIndex].transform.position;
            agent.SetDestination(targetVector);
            traveling = true;
        }
    }

    private void ChangePatrolPoint()
    {
        if(UnityEngine.Random.Range(0f, 1f) <= switchProbability)
        {
            patrolForward = !patrolForward;
        }
        if(patrolForward)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Count;
        }
        else
        {
            if(--currentPatrolIndex < 0)
            {
                currentPatrolIndex = patrolPoints.Count - 1;
            }
        }
    }


    /*private void OnTriggerEnter(Collider ruta)
    {
        / (ruta == GameObject.Find("MoveSpot"))
        {
            agent.SetDestination(pos2.position);
        }
        if (ruta == GameObject.Find("MoveSpot (1)"))
        {
            agent.SetDestination(pos3.position);
        }
        if (ruta == GameObject.Find("MoveSpot (2)"))
        {
            agent.SetDestination(pos4.position);
        }
        if (ruta == GameObject.Find("MoveSpot (3)"))
        {
            agent.SetDestination(pos1.position);
        }
    }*/

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
