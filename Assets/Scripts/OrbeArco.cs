using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbeArco : MonoBehaviour
{

    public GameObject orbeFuego;
    public bool pescarConArco=false;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.tag == "Agua2")
            {

            orbeFuego.gameObject.SetActive(false);
            pescarConArco = true;
            }
        
        
    }

    
}
