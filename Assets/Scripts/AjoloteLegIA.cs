using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class AjoloteLegIA : MonoBehaviour
{
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

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

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
                if (Input.GetButtonDown("e"))
                {

                }
            
        }
    }
}