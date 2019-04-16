using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int doorNumber;
    public string LevelToLoad;

   void OnTriggerStay()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
           // Scenemanager.instance.LoadScene(doorNumber);
            Application.LoadLevel(LevelToLoad);
        }
    }
}