using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAjolote : MonoBehaviour
{
    public GameObject ajolote;
    public float tiempoSpawn = 15f;
    public int porcentajeSpawn = 30;
    public int Spawnea;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("Spawn", tiempoSpawn, tiempoSpawn);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Spawnea = Random.Range(1, 100);
        if (Spawnea <= porcentajeSpawn)
        {
            Instantiate(ajolote, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }

}
