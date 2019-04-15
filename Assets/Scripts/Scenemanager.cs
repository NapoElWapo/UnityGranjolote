using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenemanager : MonoBehaviour
{
    public static Scenemanager instance = null;

    public GameObject player;
    public GameObject[] doorArray;

    public int currentDoorNumber;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        if (player == null)
            player = GameObject.FindGameObjectWithTag ("Player");

        if (doorArray.Length == 0)
            doorArray = GameObject.FindGameObjectsWithTag ("Door");
    }

    void OnLevelWasLoaded()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        doorArray = GameObject.FindGameObjectsWithTag ("Door");

        for (int i = 0; i < doorArray.Length; i++)
        {
            if (doorArray[i].GetComponent<Door>().doorNumber == currentDoorNumber)
            {
                player.transform.position = doorArray[i].transform.position;
            }
        }
    }

    public void LoadScene (int passedDoorNumber)
    {
        currentDoorNumber = passedDoorNumber;

        if(Application.loadedLevel == 1)
        {
            Application.LoadLevel(4);
        }
        else if (Application.loadedLevel == 4)
        {
            Application.LoadLevel(1);
        }
    }
}