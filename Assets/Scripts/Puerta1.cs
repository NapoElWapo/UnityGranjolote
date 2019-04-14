using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour
{
    public string levelToLoad;
    void Start()
    {
        
    }
   void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}