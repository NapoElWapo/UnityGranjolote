using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbeArco : MonoBehaviour
{

    public GameObject orbeFuego,lavaPesca;
    public bool pescarConArco=false;


    // Update is called once per frame
    void Update()
    {
        if (!pescarConArco)
        {
            lavaPesca.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.tag == "Agua2")
            {
            pescarConArco = true;
            lavaPesca.gameObject.SetActive(true);
            orbeFuego.gameObject.SetActive(false);
            

            }
        
        
    }

    
}
