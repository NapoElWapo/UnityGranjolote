using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int doorNumber;

    void OnTriggerStay()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
            Scenemanager.instance.LoadScene(doorNumber);
        }
    }
}