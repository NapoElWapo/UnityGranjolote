using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hielo : MonoBehaviour
{

    public GameObject hielo;
    private float limite;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {


            if (other.tag == "Agua"||other.tag=="Agua2")
            {
                hielo.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                hielo.transform.position += new Vector3(0, 0.005f, 0);
            }

            else if (other.tag == "Fuego" || other.tag == "Fuego2")
            {
                hielo.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
                hielo.transform.position -= new Vector3(0, 0.005f, 0);
            }

        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
