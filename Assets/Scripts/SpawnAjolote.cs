using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAjolote : MonoBehaviour
{
    public GameObject ajolote, ajoloteDorado;
    public float tiempoSpawn = 15f;
    public int porcentajeSpawn = 30, porcentajeDorado = 10;
    public int Spawnea, SpawnDorado;
    public int cantidadActual = 0;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("Spawn", tiempoSpawn, tiempoSpawn);
    }

    void Spawn()
    {
        if (cantidadActual < 5)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Spawnea = Random.Range(1, 100);
            if (Spawnea <= porcentajeSpawn)
            {
                SpawnDorado = Random.Range(1, 100);
                if (SpawnDorado <= porcentajeDorado)
                {
                    Instantiate(ajoloteDorado, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                }
                else
                {
                    Instantiate(ajolote, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                    cantidadActual++;
                }
            }
        }
    }
}
